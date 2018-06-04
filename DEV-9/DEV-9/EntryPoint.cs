using System;

namespace DEV_9
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Pages.LoginPage login = new Pages.LoginPage();
                login.Login("Login", "Password");
                Pages.FriendsPage friends = new Pages.FriendsPage();
                friends.OpenFriendPage("Friend name", "id");
                friends.FirstFiveFriends();
                Pages.MyPage myPage = new Pages.MyPage();
                myPage.CheckMyPage("Hanna Horskaya");
                Pages.LogOutPage logOut = new Pages.LogOutPage();
                logOut.LogOut();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
