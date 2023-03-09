using Microsoft.AspNetCore.Identity;

namespace eCom.UILayer.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {
        //hata mesajlarını kendime göre düzenlicem, override kullanırsak identityerror sınıfına bağlı hataları kendi istediğim formatta kullanmak için->override
        //kullanılmak istenen yapıyı kurallarını değiştirerek kullanmak
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = $"Şifre en az {length} karakter olmalıdır."
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "Lütfen en az 1 tane küçük harf giriniz."
            };           
        }
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresDigit",
                Description = "Lütfen en az 1 tane sayı girişi yapın."
            };
        }
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError()
            {
                Code = "DuplicateEmail",
                Description = $"Mail adresi: {email} zaten sistemde mevcut, lütfen farklı bir mail adresi ile kayıt olun."
            };
        }
        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError()
            {
                Code = "DuplicateUserName",
                Description=$"Kullanıcı adı: {userName} zaten sistemde mevcut, lütfen farklı bir kullanıcı adı ile kayıt olun."
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Şifre en az bir özel karakter içermeli."
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Lütfen en az 1 tane büyük harf giriniz."
            };
        }

    }
}
