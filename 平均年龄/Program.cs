
using CDS005.IListWithGenericsDemo.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDS005.IListWithGenericsDemo
{
    class Program
    {
       public  static void Main(string [] arg)
        {
            Console.Title = "关于 IList<T> 实现的说明";
            PersonListRepository list = new PersonListRepository();
            var persons = PersonListRepository.InitialPersonList();

            var a = PersonListRepository.AverageAge(persons);
            Console.WriteLine(a);
            Console.WriteLine("-------------------------------------");            var w = PersonListRepository.InitialPersonList();
            pgdoj(w);
            
            Console.ReadKey();


            // 遍历显示全部的元素
            //Console.WriteLine("1.列出全部的人员数据 ");
            //Console.WriteLine("--------------------------------------------------------------------------");

            //foreach (var person in persons)
            //    Console.WriteLine(person.ToString());
            //Console.WriteLine("--------------------------------------------------------------------------");
            //Console.ReadKey();
            //Console.Clear();

            //// 添加一个元素
            //var person01= new Person {
            //    Name = "蒋玉琳",
            //    Province = "广西",
            //    City = "柳州",
            //    Sex = false,
            //    Birthday = DateTime.Parse("1989-09-08"),
            //    Email = "jiangyl@hotmail.com"
            //};
            //persons.Add(person01);
            //Console.WriteLine("2.列出添加了一个人员的全部人员数据 ");
            //Console.WriteLine("--------------------------------------------------------------------------");
            //foreach (var person in persons)
            //    Console.WriteLine(person.ToString());
            //Console.WriteLine("--------------------------------------------------------------------------");
            //Console.ReadKey();
            //Console.Clear();

            //// 移除一个元素
            //persons.Remove(person01);
            //Console.WriteLine("3.列出删除了一个人员的全部人员数据 ");
            //Console.WriteLine("--------------------------------------------------------------------------");
            //foreach (var person in persons)
            //    Console.WriteLine(person.ToString());
            //Console.WriteLine("--------------------------------------------------------------------------");
            //Console.ReadKey();
            //Console.Clear();

            //// 更新一个元素
            //var editPerson = persons.FirstOrDefault(x => x.Name == "韦大东");
            //if (editPerson != null)
            //{
            //    editPerson.Email = "weidadong@yahoo.com";
            //}
            //Console.WriteLine("4.列出更新了一个人员的全部人员数据 ");
            //Console.WriteLine("--------------------------------------------------------------------------");
            //foreach (var person in persons)
            //    Console.WriteLine(person.ToString());
            //Console.WriteLine("--------------------------------------------------------------------------");
            //Console.ReadKey();
            //Console.Clear();

            //// 在指定的位置插入一个新的元素：在 韦大东 后面插入一个对象
            //var localPerson = persons.FirstOrDefault(x => x.Name == "韦大东");
            //if (localPerson != null)
            //{
            //    persons.Insert(persons.IndexOf(localPerson)+1, person01);
            //}
            //Console.WriteLine("5.列出在指定位置插入一个人员的全部人员数据 ");
            //Console.WriteLine("--------------------------------------------------------------------------");
            //foreach (var person in persons)
            //    Console.WriteLine(person.ToString());
            //Console.WriteLine("--------------------------------------------------------------------------");
            //Console.ReadKey();
            //Console.Clear();

            //// 查询：选择所有城市=柳州的成员
            //Console.WriteLine("6.列出在所有城市=柳州的全部人员数据 ");
            //Console.WriteLine("--------------------------------------------------------------------------");
            //var liuzhouPersons = persons.Where(x => x.City == "柳州");
            //foreach (var person in liuzhouPersons)
            //    Console.WriteLine(person.ToString());
            //Console.WriteLine("--------------------------------------------------------------------------");
            //Console.ReadKey();
            //Console.Clear();

            //// 查询：获取全部人员来自哪些省份的数据
            //Console.WriteLine("7.列出全部人员来自哪些省份 ");
            //Console.WriteLine("--------------------------------------------------------------------------");
            //var provinces = PersonListRepository.GetProvinces(persons);
            //foreach (var item in provinces)
            //    Console.WriteLine(item);
            //Console.WriteLine("--------------------------------------------------------------------------");
            //Console.ReadKey();
            //Console.Clear();

            //// 查询：获取全部人员来自哪些省份的数据
            //Console.WriteLine("8.列出全部人员来自哪些省份 ");
            //Console.WriteLine("--------------------------------------------------------------------------");
            //var provinces01 = PersonListRepository.GetProvincesGroupBy(persons);
            //foreach (var item in provinces01)
            //    Console.WriteLine(item);
            //Console.WriteLine("--------------------------------------------------------------------------");
            //Console.ReadKey();
            //Console.Clear();

            //// 查询：获取省份人员数量的数据
            //Console.WriteLine("9.列出全部人员来自哪些省份 ");
            //Console.WriteLine("--------------------------------------------------------------------------");
            //var provinceData = PersonListRepository.GetProvincesPersons(persons);
            //foreach (var item in provinceData)
            //    Console.WriteLine(item.ToBarChartStyle());
            //Console.WriteLine("--------------------------------------------------------------------------");
            //Console.ReadKey();
            //Console.Clear();
        }
        public static void  pgdoj(PersonList   per)
        {
            var b = from a in per
                    where !a.Name.Contains("欧阳")
                    group a by a.Name.Substring(0, 1)
                  into box
                    select new { box.Key, sum = box.Count() };

            foreach (var i in b )
            {
                Console.WriteLine("姓：{0}，人数：{1}",i.Key,i.sum );
            }



            var name = from a in per
                  where a.Name.Contains("欧阳") 
                    group a by a.Name.Substring(0, 2)
                  into box
                    select new { box.Key, sum = box.Count() };

            foreach (var i in name)
            {
                Console.WriteLine("姓：{0}，人数：{1}", i.Key, i.sum);
            }
            Console.Read();
        }

    }
   
}
