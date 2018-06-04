namespace DEV_9.Locators
{
    class XpathLocators
    {
        //Login page 
        public static readonly string LoginBlock = @"//form[@name='login']";
        public static readonly string LoginInputForm = @"//input[@id='index_email']";
        public static readonly string PasswordInputForm = @"//input[@id='index_pass']";
        public static readonly string LoginButton = @"//button[@id='index_login_button']";

        //LogOut page
        public static readonly string LoginOutMeny = "//a[@id='top_profile_link']";
        public static readonly string LoginOutButton = "//a[@id='top_logout_link']";

        //Friends page
        public static readonly string FriendsInfo = "//div[@class='friends_user_info']";

        //Message page
        public static readonly string MessageSpace = "//*[@id=\'mail_box_editable\']";
        public static readonly string SendMessagButton = "//*[@id=\'mail_box_send\']";
        public static readonly string SendButton = "//*[@id=\"mail_box_send\"]";

        //Profile page
        public static readonly string ProfilePageButton = @"//li[@id = 'l_pr']";
        public static readonly string Name = "//div/h2[@class=\"page_name\"]";
    }
}
