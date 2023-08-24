using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.DependencyResolver.Ninject;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            IMemberService memberService = InstanceFactory.GetInstance<IMemberService>();

            memberService.Add(new Member
            {
                FirstName = "ad",
                LastName="soyad",
                DateOfBirth=new DateTime(1919,5,19),
                TcNo = "12312312312",
                Email="mail@gmail.com"
            });

            Console.WriteLine("Eklendi");
            Console.ReadLine();


        }
    }
}
