//класс с переменными для задания параметров отправки письма
namespace WpfTestMailSender
{
    public static class MailSet
    {
       public struct server
        {
            const string yandex = "smtp.yandex.ru";
            const int portYandex = 25;
            public string Yandex { get { return yandex; } }
            public int PortYandex { get { return portYandex; } }
        }

      // static List<string> listStrMails = new List<string>();
       

        public static string textMessageCaption;
        public static string textMesageBody;
        public static string toSend;
 
        public static string user;
        public static string pass;
        public static string addAttachAdr;

    }
}
