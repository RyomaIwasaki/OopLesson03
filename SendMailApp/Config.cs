using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml;
using System.Xml.Serialization;

namespace SendMailApp {
    public class Config {
        private static Config Instance;

        public static Config GetInstance() {
            if (Instance == null) {
                Instance = new Config();
            }
            return Instance;
        }

        public string Smtp { get; set; }        //SMTPサーバ
        public string MailAddress { get; set; }     //自メールアドレス
        public string PassWord { get; set; }        //パスワード
        public int Port { get; set; }       //ポート番号
        public bool Ssl { get; set; }       //SSL設定

        //コンストラクタ(外部からnewできないようにする)
        private Config() { }

        //初期設定用
        public void DefaultSet() {
            Smtp = "smtp.gmail.com";
            MailAddress = "ojsinfosys01@gmail.com";
            PassWord = "ojsInfosys2020";
            Port = 587;
            Ssl = true;
        }

        //初期値取得用
        public Config getDefaultStatus() {
            Config obj = new Config {
                Smtp = "smtp.gmail.com",
                MailAddress = "ojsinfosys01@gmail.com",
                PassWord = "ojsInfosys2020",
                Port = 587,
                Ssl = true,
            };
            return obj;
        }

        //設定データ更新
        //public bool UpdateStatus(Config cf) {
        public bool UpdateStatus(string smtp, string mailAddress, string passWord, int port, bool ssl) {
            this.Smtp = smtp;
            this.Port = port;
            this.MailAddress = mailAddress;
            this.PassWord = passWord;
            this.Ssl = ssl;
            return true;
        }

        public void Serialise() {       //シリアル化 
            try {
                XmlSerializer xs = new XmlSerializer(typeof(Config));
                StreamWriter sw = new StreamWriter("Config.xml");
                Config cf = Config.GetInstance();
                xs.Serialize(sw, cf);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        public void DeSerialise() {     //逆シリアル化 
            try {
                using (StreamReader sr = new StreamReader("Config.xml")) {
                    XmlSerializer xs = new XmlSerializer(typeof(Config));
                    Instance = xs.Deserialize(sr) as Config;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
    }
}
