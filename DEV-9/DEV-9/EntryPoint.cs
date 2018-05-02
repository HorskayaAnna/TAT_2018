using System.Threading;


namespace DEV_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login();
            login.LoginVk("375293694107", "fyyfujhcrfzvehveh");
            Thread.Sleep(10000);
            AreMyPage page = new AreMyPage();
            page.CheckMyPage();
            //FirstFriends friends = new FirstFriends();
            //friends.FirstFiveFriends();
            // SendMessage m = new SendMessage();
            //m.SendingMessage("Анна Горская", 70111692);
           // LogOut logOut = new LogOut();
            //logOut.LoginOut();
        }
    }
}
