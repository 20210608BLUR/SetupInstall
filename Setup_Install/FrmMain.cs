using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.IO.Compression;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using static System.Collections.Specialized.BitVector32;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;
using static System.Windows.Forms.LinkLabel;

namespace Setup_Install
{
    public partial class FrmMain : Form
    {
        // 表單變數 START
        string appName = "JING_Setup";
        string appPath = Application.StartupPath;
        string language = string.Empty;
        string languagePath = string.Empty;
        string textFilePath = string.Empty; // 檔案路徑文字
        string pathLine = string.Empty; // 檔案路徑
        string user = Environment.UserName;
        int i = 0;
        // 表單變數 END

        // 表單初始化
        public FrmMain()
        {
            InitializeComponent();            
        }


        // 表單載入
        private void FrmMain_Load(object sender, EventArgs e)
        {            
            try
            {
                // 設定程式在螢幕正中間
                this.Size = new Size(513, 416);  // 設定成跟微軟官方的安裝程式一樣大小
                int x = (SystemInformation.WorkingArea.Width - this.Size.Width) / 2;
                int y = (SystemInformation.WorkingArea.Height - this.Size.Height) / 2;
                this.StartPosition = FormStartPosition.Manual;
                this.Location = (Point)new Size(x, y);
                this.Text = appName;

                // 防止程式重覆執行
                string processName = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
                System.Diagnostics.Process[] myProcess = System.Diagnostics.Process.GetProcessesByName(processName);
                if (myProcess.Length > 1) { Environment.Exit(0); }             
                
                // 語系               
                cmb.Items.Add("繁體中文");
                cmb.Items.Add("简体中文");
                cmb.Items.Add("English");
                cmb.SelectedIndex = 0;

                languagePath = Application.StartupPath + "\\" + language + ".txt";

                // 將物件設定成跟微軟官方的安裝程式一樣大小 START
                lbl_Line1.Size = new Size(497, 1);
                lbl_Line1.Location = new Point(0, 64);

                lbl_Line2.Size = new Size(497, 1);
                lbl_Line2.Location = new Point(0, 331);

                Btn_Prev.Size = new Size(88, 23);
                Btn_Prev.Location = new Point(209, 342);
                Btn_Prev.Enabled = false;
                Btn_Prev.Text = Ini_Read(languagePath, "System", "Btn_Prev");

                Btn_Next.Size = new Size(88, 23);
                Btn_Next.Location = new Point(304, 342);
                Btn_Next.Text = Ini_Read(languagePath, "System", "Btn_Next");

                Btn_Cancel.Size = new Size(88, 23);
                Btn_Cancel.Location = new Point(400, 342);
                Btn_Cancel.Text = Ini_Read(languagePath, "System", "Btn_Cancel");

                btnOpen.Text = Ini_Read(languagePath, "System", "Browse");

                pic.Size = new Size(497, 45);
                pic.Location = new Point(0, 0);

                prg.Location = new Point(30, 150);
                prg.Size = new Size(440, 20);
                prg.Visible = false;

                cmb.Location = new Point(18, 150);

                lbl_Title.Size = new Size(440, 30);
                lbl_Title.Location = new Point(80, 15);

                lbl_Content1.Size = new Size(440, 50);
                lbl_Content1.Location = new Point(15, 80);

                lbl_Content2.Size = new Size(440, 60);
                lbl_Content2.Location = new Point(15, 250);

                lbl_Content3.Size = new Size(440, 30);
                lbl_Content3.Location = new Point(15, 130);

                pnl_Welcome.Size = new Size(516, 316);
                pnl_Welcome.Location = new Point(0, 0);
                pnl_Welcome.Visible = true;


                // 將物件設定成跟微軟官方的安裝程式一樣大小 END

                // 判斷檔案路徑是否存在
                if (Check() == true)
                {
                    tmr_Welcome.Start();

                    cmb.Visible = false;
                    lbl_Content2.Visible = false;
                    lbl_Content3.Visible = false;
                    rdo_Reset.Location = new Point(18, 120);
                    rdo_Reset.Visible = true;
                    rdo_Remove.Location = new Point(18, 150);
                    rdo_Remove.Visible = true;
                    lbl_Welcome.Text = "WELCOME BACK !";
                    lbl_Welcome.Location = new Point(100, 230);

                    lbl_Content1.Text = "選擇要修復或移除";
                    Btn_Next.Text = "完成";
                }
                else
                {
                    tmr_Welcome.Start();

                    // 設定初始文字              
                    lbl_Title.Text = Ini_Read(languagePath, "System", "First_Title");
                    lbl_Content1.Text = Ini_Read(languagePath, "System", "First_Content");
                    lbl_Content2.Text = Ini_Read(languagePath, "System", "First_License");
                    lbl_Content3.Text = Ini_Read(languagePath, "System", "First_Choose");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // 選擇語言
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb.Text == "繁體中文")
            {
                language = "LanguageTW";
            }
            else if (cmb.Text == "简体中文")
            {
                language = "LanguageCN";
            }
            else
            {
                language = "LanguageEN";
            }

            languagePath = Application.StartupPath + "\\" + language + ".txt";

            Btn_Next.Text = Ini_Read(languagePath, "System", "Btn_Next");
            Btn_Prev.Text = Ini_Read(languagePath, "System", "Btn_Prev");
            Btn_Cancel.Text = Ini_Read(languagePath, "System", "Btn_Cancel");
            btnOpen.Text = Ini_Read(languagePath, "System", "Browse");

            lbl_Title.Text = Ini_Read(languagePath, "System", "First_Title");
            lbl_Content1.Text = Ini_Read(languagePath, "System", "First_Content");
            lbl_Content2.Text = Ini_Read(languagePath, "System", "First_License");
            lbl_Content3.Text = Ini_Read(languagePath, "System", "First_Choose");
        }       
       
        
        private void Btn_Prev_Click(object sender, EventArgs e)
        {
            i--;
            StepPrev();
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            i++;

            if (Btn_Next.Text == "完成")
            {
                MessageBox.Show("已成功完成!");
                this.Dispose();
                this.Close();
                Environment.Exit(0);
            }            
            else
            {
                StepNext();
            }
        }

        // 瀏覽資料夾
        private void btnOpen_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog();
            txt.Text = folderBrowserDialog1.SelectedPath;
            textFilePath = folderBrowserDialog1.SelectedPath;

        }

        // 修復
        private void rdo_Reset_CheckedChanged(object sender, EventArgs e)
        {
            Zip();
        }

        // 移除
        private void rdo_Remove_CheckedChanged(object sender, EventArgs e)
        {
            RemoveFile();
        }


        //  歡迎畫面 
        private void tmr_Welcome_Tick(object sender, EventArgs e)
        {            
            pnl_Welcome.Visible = false;
            tmr_Welcome.Stop();          
        }


        // 用 timer 計算開始安裝檔案
        private void tmr_Zip_Tick(object sender, EventArgs e)
        {
            // 判斷解壓縮是否成功
            IsSuccess();
            tmr_Zip.Stop();
        }      
        

        // 歡迎使用 (多語系)
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        // 讀取 INI (INI 的路徑, 要讀取的區段, 要讀取的 Key 值)
        private string Ini_Read(string ini_Path, string section, string key)
        {
            try
            {
                if (ini_Path.Length == 0) { return ""; }
                if (File.Exists(ini_Path) == false) { return ""; }

                var result = new StringBuilder(300);
                GetPrivateProfileString(section, key, "", result, 300, ini_Path);

                string strResult = result.ToString();

                return strResult;
            }
            catch
            {
                return "";
            }
        }

        // 上一步
        public void StepPrev()
        {
            languagePath = Application.StartupPath + "\\" + language + ".txt";

            // 0 選擇語言
            if (i == 0)
            {
                txt.Visible = false;
                btnOpen.Visible = false;
                cmb.Visible = true;

                Btn_Prev.Enabled = false;

                lbl_Content2.Location = new Point(15, 250);

                lbl_Title.Text = Ini_Read(languagePath, "System", "First_Title");
                lbl_Content1.Text = Ini_Read(languagePath, "System", "First_Content");
                lbl_Content2.Text = Ini_Read(languagePath, "System", "First_License");
                lbl_Content3.Text = Ini_Read(languagePath, "System", "First_Choose");

                Btn_Next.Text = Ini_Read(languagePath, "System", "Btn_Next");
                Btn_Prev.Text = Ini_Read(languagePath, "System", "Btn_Prev");
                Btn_Cancel.Text = Ini_Read(languagePath, "System", "Btn_Cancel");
                btnOpen.Text = Ini_Read(languagePath, "System", "Browse");
            }
            // 1 選擇安裝資料夾
            else if (i == 1)
            {
                cmb.Visible = false;
                txt.Visible = true;
                lbl_Content3.Visible = true;
                btnOpen.Visible = true;
                Btn_Prev.Enabled = true;

                lbl_Content2.Location = new Point(30, 170);
                lbl_Content3.Location = new Point(15, 100);

                btnOpen.Location = new Point(390, 190);

                txt.Size = new Size(350, 20);
                txt.Location = new Point(30, 190);

                //label1.Text = "選擇安裝資料夾";
                lbl_Title.Text = Ini_Read(languagePath, "System", "Two_Title");
                //label2.Text = "安裝程式將安裝櫃台數位化(CDS)至下列資料夾。";
                lbl_Content1.Text = Ini_Read(languagePath, "System", "Two_Content1");
                //label3.Text = "資料夾(F):";
                lbl_Content2.Text = Ini_Read(languagePath, "System", "Folder");
                //label4.Text = "若要在此資料夾中安裝，請按[下一步]。若要安裝至不同的資料夾，請在下列方塊輸入資料夾位置或按[瀏覽]。";
                lbl_Content3.Text = Ini_Read(languagePath, "System", "Two_Content3");
            }
        }

       
        // 下一步
        public void StepNext()
        {
            tmr_Welcome.Stop();
            tmr_Zip.Start();
            languagePath = Application.StartupPath + "\\" + language + ".txt";            

            // 選擇語言
            Btn_Next.Text = Ini_Read(languagePath, "System", "Btn_Next");
            Btn_Prev.Text = Ini_Read(languagePath, "System", "Btn_Prev");
            Btn_Cancel.Text = Ini_Read(languagePath, "System", "Btn_Cancel");
            btnOpen.Text = Ini_Read(languagePath, "System", "Browse");

            // 1 選擇安裝資料夾
            if (i == 1)
            {
                cmb.Visible = false;
                txt.Visible = true;
                btnOpen.Visible = true;

                Btn_Prev.Enabled = true;

                lbl_Content2.Location = new Point(30, 170);
                lbl_Content3.Location = new Point(15, 100);

                btnOpen.Location = new Point(390, 190);

                txt.Size = new Size(350, 20);
                txt.Location = new Point(30, 190);

                //label1.Text = "選擇安裝資料夾";
                lbl_Title.Text = Ini_Read(languagePath, "System", "Two_Title");
                //label2.Text = "安裝程式將安裝櫃台數位化(CDS)至下列資料夾。";
                lbl_Content1.Text = Ini_Read(languagePath, "System", "Two_Content1");
                //label3.Text = "資料夾(F):";
                lbl_Content2.Text = Ini_Read(languagePath, "System", "Folder");
                //label4.Text = "若要在此資料夾中安裝，請按[下一步]。若要安裝至不同的資料夾，請在下列方塊輸入資料夾位置或按[瀏覽]。";
                lbl_Content3.Text = Ini_Read(languagePath, "System", "Two_Content3");

            }
            // 2 確認安裝｝
            else if (i == 2)
            {
                txt.Visible = false;
                btnOpen.Visible = false;
                lbl_Content3.Visible = false;

                lbl_Content2.Location = new Point(15, 100);

                //label1.Text = "確認安裝";
                lbl_Title.Text = Ini_Read(languagePath, "System", "Three_Title");
                //label2.Text = "安裝程式已經準備好在您的電腦上安裝櫃台數位化(CDS)。";
                lbl_Content1.Text = Ini_Read(languagePath, "System", "Three_Content");
                //label3.Text = "請按[下一步]開始安裝。";               
                lbl_Content2.Text = Ini_Read(languagePath, "System", "Three_Content2");

                // 建立檔案路徑
                FilePath();
            }
            // 3 正在安裝 
            else if (i == 3)
            {
                Btn_Next.Enabled = false;
                Btn_Prev.Enabled = false;
                Btn_Cancel.Enabled = false;

                lbl_Content2.Location = new Point(30, 130);

                //label1.Text = "正在安裝";
                lbl_Title.Text = Ini_Read(languagePath, "System", "Four_Title");
                //label2.Text = "正在安裝櫃台數位化(CDS)。";
                lbl_Content1.Text = Ini_Read(languagePath, "System", "Four_Content");
                //label3.Text = "請稍等...";
                lbl_Content2.Text = Ini_Read(languagePath, "System", "Wait");

                //Application.DoEvents();
                //Zip();
            }
            else
            {
                string path = $@"C:\Users\{user}\AppData\Local\zip.txt";
                
                using (StreamReader sr = new StreamReader(path))
                {
                    pathLine = sr.ReadLine();
                }
                // 建立捷徑
                CreateShortcut(pathLine, appName);
                this.Dispose();
                this.Close();
                Environment.Exit(0);
            }

        }


        // 解壓縮
        public bool Zip()
        {
            bool overwrite = true; // 檔案覆寫
            string zipPath = Application.StartupPath + "\\skl-eteller-client-0112.zip";
            string extractPath = txt.Text;
            ZipArchive archive = ZipFile.OpenRead(zipPath);

            this.prg.Visible = true;
            this.prg.Value = 0;
            this.prg.Maximum = archive.Entries.Count();
            this.prg.Minimum = 0;
            this.prg.MarqueeAnimationSpeed = 100;

            try
            {
                foreach (ZipArchiveEntry file in archive.Entries)
                {    

                    if (file.Name == "")
                    {
                        string desPath = Path.Combine(extractPath, file.FullName);

                        if (!Directory.Exists(desPath))
                        {
                            Directory.CreateDirectory(desPath);
                        }
                    }
                    else
                    {
                        // 建立新資料夾 
                        if (!Directory.Exists(extractPath))
                        {
                            Directory.CreateDirectory(extractPath);
                        }

                        string desFileName = Path.Combine(extractPath, file.FullName);

                        // 可以覆寫
                        if (overwrite)
                        {
                            file.ExtractToFile(desFileName, true);
                        }
                        else
                        {
                            // 如不可覆寫就判斷檔案是否存在 不存在才解壓縮
                            if (!File.Exists(desFileName))
                            {
                                file.ExtractToFile(desFileName);
                            }
                        }                        
                    }

                    // 進度條
                    if (lbl_Title.Text == "正在安裝")
                    {                       
                        this.prg.Value += 1;
                        this.prg.Visible = true;
                    }
                    else
                    {
                        this.prg.Visible = false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                LogMessage(ex.ToString());
                return false;
            }

        }

        // 判斷解壓縮是否成功
        public void IsSuccess()
        {

            if (lbl_Title.Text == "正在安裝" || lbl_Title.Text == "正在安装" || lbl_Title.Text == "Installing")
            {
                // 安裝檔案成功 
                if (Zip() == true)
                {
                    Btn_Prev.Enabled = false;
                    Btn_Cancel.Enabled = false;
                    Btn_Next.Enabled = true;
                    prg.Visible = false;

                    //Btn_Next.Text = "關閉(C)";
                    Btn_Next.Text = Ini_Read(languagePath, "System", "Five_Btn");

                    lbl_Content2.Location = new Point(15, 100);

                    //label1.Text = "安裝完成";
                    lbl_Title.Text = Ini_Read(languagePath, "System", "Five_Title");
                    //label2.Text = "櫃台數位化(CDS)已經成功安裝。";
                    lbl_Content1.Text = Ini_Read(languagePath, "System", "Five_Content");
                    //label3.Text = "請按[關閉]結束安裝程式";
                    lbl_Content2.Text = Ini_Read(languagePath, "System", "Five_Content2");
                }
                else
                {
                    MessageBox.Show("安裝失敗!");
                }
            }
        }

        // 判斷檔案路徑是否存在
        public bool Check()
        {
            try
            {
                string path = $@"C:\Users\{user}\AppData\Local\zip.txt";

                if (File.Exists(path))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                LogMessage(ex.ToString());
                return false;
            }

        }

        // 建立檔案路徑
        public void FilePath()
        {
            try
            {
                string path = $@"C:\Users\{user}\AppData\Local\zip.txt";

                textFilePath = txt.Text;

                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(textFilePath);
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                LogMessage(ex.ToString());
            }
        }

        // 移除檔案
        public void RemoveFile()
        {
            try
            {
                string path = $@"C:\Users\{user}\AppData\Local\zip.txt";
                string deskTop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
                string shortcutFileName = deskTop + appName + ".lnk";

                using (StreamReader sr = new StreamReader(path))
                {
                    pathLine = sr.ReadLine();
                }

                // 移除檔案目錄
                File.Delete(path);

                // 移除檔案資料夾
                Directory.Delete(pathLine, true);                

                // 移除捷徑
                if (File.Exists(shortcutFileName) == true)
                {
                    File.Delete(shortcutFileName);
                }
            }
            catch (Exception ex)
            {
                LogMessage(ex.ToString());
            }
        }


        // 建立桌面捷徑 By Jason (檔案完整路徑, 捷徑描述)
        private void CreateShortcut(string lnkFilePath, string fileDescript = "")
        {
            try
            {
                string deskTop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
                string shortcutFileName = deskTop + fileDescript + ".lnk";
                string workDir = Path.GetDirectoryName(lnkFilePath);

                if (File.Exists(shortcutFileName) == true)
                {
                    File.Delete(shortcutFileName);
                }

                var shellType = Type.GetTypeFromProgID("WScript.Shell");
                dynamic shell = Activator.CreateInstance(shellType);
                var shortcut = shell.CreateShortcut(shortcutFileName);

                shortcut.TargetPath = lnkFilePath;
                shortcut.Description = fileDescript;
                shortcut.WorkingDirectory = workDir;
                shortcut.IconLocation = shell.ExpandEnvironmentStrings(lnkFilePath + ", 0");
                shortcut.Save();

            }
            catch (Exception ex)
            {
                LogMessage(ex.ToString());
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Environment.Exit(0);
        }


        // 表單關閉
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
            }
            catch
            {
            }

            this.Dispose();
            this.Close();
            Environment.Exit(0);
        }


        /*** 副程式 START *************************************************************************/


        // 格式化現在的時間
        private static string FormatNow()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }


        // 記錄 Log 副程式 (要記錄的訊息)
        private void LogMessage(string message = "")
        {
            try
            {
                string logMsg = "";

                // 檢查 Log 目錄
                if (Directory.Exists(appPath + "\\Log") == false)
                {
                    Directory.CreateDirectory(appPath + "\\Log");
                }

                // Log 訊息內容
                logMsg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "  " + message;

                // 寫入 Log
                FileStream logFile = File.Open(appPath + "\\Log\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".log", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                StreamWriter logWriter = new StreamWriter(logFile);
                logWriter.WriteLine(logMsg);
                logWriter.Dispose();
                logFile.Dispose();

            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        






        /*** 副程式 END ***************************************************************************/




    }
}
