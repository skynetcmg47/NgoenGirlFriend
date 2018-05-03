using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ngoenGirlFriend.Bean
{
    public class GirlFriend
    {
        string ID, fullName, phone, email, birthDate, note;
        bool status;
        float rating;
        int ratingAmount;
        address gAddress;

        public string ID1
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }

        public string FullName
        {
            get
            {
                return fullName;
            }

            set
            {
                fullName = value;
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

        public string Note
        {
            get
            {
                return note;
            }

            set
            {
                note = value;
            }
        }

        public bool Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public float Rating
        {
            get
            {
                return rating;
            }

            set
            {
                rating = value;
            }
        }

        public int RatingAmount
        {
            get
            {
                return ratingAmount;
            }

            set
            {
                ratingAmount = value;
            }
        }

        public address GAddress
        {
            get
            {
                return gAddress;
            }

            set
            {
                gAddress = value;
            }
        }
    }
}