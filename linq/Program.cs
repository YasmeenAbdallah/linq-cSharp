using System;
using System.Linq;
using System.Collections;
namespace linq
{


    class Program
    {
        public static void QueryStringArray()
        {
            string[] dogs = { "dog 1", "hello dogs", "dog" };
            var dogSpaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog ascending
                            select dog;

            foreach (var i in dogSpaces)
            {
                Console.WriteLine(i);
            }
        }
        public static void QueryIntArray()
        {
            int[] nums = { 10, 20, 8, 7, 9, 6, 3,40,45 };
            var gt20 = from num in nums
                       where num > 20
                       orderby num
                       select num;
            foreach (var item in gt20)
            {
                Console.WriteLine(item);
            }
            //get the current type of var
            Console.WriteLine(gt20.GetType());

            //convert it 
            var AsList = gt20.ToList<int>();
            var AsArray = gt20.ToArray();

            Console.WriteLine(AsList.GetType());
            Console.WriteLine(AsArray.GetType());
        }
        public static void QueryAsArrayList()
        {
            ArrayList animals = new ArrayList()
           {
               new Animal
               {
                    Name="animal 1",
                    Height = 10,
                    weight = 21.5,
                    AnimalId=1

               },
               new Animal
               {
                   Name="animal 2",
                    Height = 20,
                    weight = 11.5,
                    AnimalId=2
               },
                new Animal
               {
                   Name="animal 3",
                    Height = 30,
                    weight = 31.5,
                    AnimalId=3
               },
           };


            ArrayList Owners = new ArrayList()
           {
               new Owner
               {
                    Name="yasmeen",
                    OwnerId = 1,


               },
                new Owner
               {
                    Name="mariam",
                    OwnerId = 11,


               },
            };
            //CONVERT THE ARR TO ANIMA TYPE
            // did uunderstant why he do that? 
            var animalsType = animals.OfType<Animal>();
            var OwnersType = Owners.OfType<Owner>();
            var smAnimal = from ani in animalsType
                           where ani.Height < 20&& ani.Height>2
                           orderby ani.Name
                           select ani;

            var nameAnimal = from ani in animalsType
                         
                           select new { ani.Height, ani.Name };

            foreach (var j in nameAnimal)
            {
                Console.WriteLine(j);


            }

            var joinNames = from ani in animalsType
                            join owner in OwnersType
                            on ani.AnimalId equals owner.OwnerId
                            select new
                            {
                                oname = owner.Name,
                                anmae = ani.Name
                            };
            foreach (var item in joinNames)
            {
                Console.WriteLine($"the {item.oname} owns {item.anmae}"  );
            }

            //nested query
            var joininto = from ani in animalsType
                           join owner in OwnersType
                           on ani.AnimalId equals owner.OwnerId
                           into groupq
                           select new
                           {
                               Name = owner.Name,
                               animal = from ow2 in groupq
                                        orderby ow2.Name
                                        select ow2

                                        

                           };
            foreach (var item in joininto)
            {

            }

                


    }


        static void Main(string[] args)
        {
            // QueryIntArray();
            //QueryStringArray();
            QueryAsArrayList();
        }
    }
}
