﻿using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.Business.ServiceAdapters
{
    public class KpsServiceAdapter : IKpsService
    {
        KpsServiceReference.KPSPublicSoapClient client = new KpsServiceReference.KPSPublicSoapClient();
        public bool ValidateUser(Member member)
        {
            return client.TCKimlikNoDogrula(Convert.ToInt64(member.TcNo),member.FirstName.ToUpper(),member.LastName.ToUpper(),member.DateOfBirth.Year);
        }
    }
}
