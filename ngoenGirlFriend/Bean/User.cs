using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ngoenGirlFriend.Bean
{
    public class User
    {
        string userName,passWord,FullName,birthDate,phone,email,imageUrl;
        address uaddress;

        public string BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                birthDate = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string FullName1
        {
            get
            {
                return FullName;
            }

            set
            {
                FullName = value;
            }
        }

        public string ImageUrl
        {
            get
            {
                return imageUrl;
            }

            set
            {
                imageUrl = value;
            }
        }

        public string PassWord
        {
            get
            {
                return passWord;
            }

            set
            {
                passWord = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        private address Uaddress
        {
            get
            {
                return uaddress;
            }

            set
            {
                uaddress = value;
            }
        }

    }
}