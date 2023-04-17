using System;
namespace userClass
{
	public class UserInfo
	{
	 public string User { get; set; }
     public string Pass { get; set; }
        public string Role { get; set; }
        public bool IsDeleted { get; set; }
        public UserInfo(string user, string pass, string role)
        {
            User = user;
            Pass = pass;
            Role = role;

        }
        public UserInfo()
        {


        }

        public override string ToString()
        {
            return "Пользователь - " + User + "Пароль - " + Pass + "Роль - " + Role + "Удалел ли аккаунт?" + IsDeleted;
        }
    }
}

