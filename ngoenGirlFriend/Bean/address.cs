using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ngoenGirlFriend.Bean
{
    public class address
    {
        int distric, province, ward;
        public address(int ward1, int distric1, int province1)
        {
            Distric = distric1;
            Ward = ward1;
            Province = province1;
        }

        public int Distric
        {
            get
            {
                return distric;
            }

            set
            {
                distric = value;
            }
        }

        public int Province
        {
            get
            {
                return province;
            }

            set
            {
                province = value;
            }
        }

        public int Ward
        {
            get
            {
                return ward;
            }

            set
            {
                ward = value;
            }
        }
    }
}