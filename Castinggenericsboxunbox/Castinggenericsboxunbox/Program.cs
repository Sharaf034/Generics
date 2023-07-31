
// boxing-----

//int num = 5;

//object t = num;

//num = 100;

//Console.WriteLine(num);


//unboxing-----

//int num = 5;

//object t = num;

//int j = (int)t;



//using Castinggenericsboxunbox;

//Animal animal1 = new Animal();

//Fish fish1 = new Fish();

//Animal animal3 = fish1;

//Animal animal2 = new Fish();

//Fish fish3 = (Fish)animal2;

//Book book = new Book();


//object[] animals = { book, 1, "Salam", animal1, animal3, animal2, fish1, fish3 };

//foreach (var item in animals)
//{

//    Animal animal = item as Animal;
//    if (animal != null)
//    {
//        animal.Name = "canavar";
//        Console.WriteLine(animal.Name);
//    }
//if (item is Animal)
//{
//    ((Animal)item).Name = "Tulku"
//Console.WriteLine(((Animal)item).Name);
//}
//}



//byte num1  = 5;

//int num2 = num1;


//int num1 = 50;

//byte num2 = (byte)num1;

//Console.WriteLine(num2);


//Test();

//static void Test(int? a = 5)
//{
//    Test2((int)a);
//}


//static void Test2(int m)
//{

//}




//using Castinggenericsboxunbox;

//IntList intList = new IntList();
//intList.Add(5);
//intList.Add(15);

//var result = intList.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}



//StringList stringList = new StringList();
//stringList.Add("salam");
//stringList.Add("salamlar");

//var res = stringList.GetAll();

//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}



//DataList<int> datas = new DataList<int>();
//datas.Add(1);
//datas.Add(2);
//datas.Add(3);
//datas.Add(4);

//var result = datas.Getall();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}



//DataList<string> list = new DataList<string>();
//list.Add("Salam1");
//list.Add("Salam2");
//list.Add("Salam3");
//list.Add("Salam4");
    
//var res = list.Getall();

//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}


//DataList<bool> turn = new DataList<bool>();
//turn.Add(true);
//turn.Add(false);

//var rest = turn.Getall();

//foreach (var item in rest)
//{
//    Console.WriteLine(item);
//}




//DataList<Book1> books = new DataList<Book1>();

//books.Add(new Book1 { Id = 1, Name = "Xosrov ve Shirin" });
//books.Add(new Book1 { Id = 2, Name = "Isgendername" });

//var result1 = books.Getall();

//foreach (var item in result1)
//{
//    Console.WriteLine(item.Name);
//}


//Repository<string> data1 = new Repository<string>();
//Repository<Book2> data2 = new Repository<Book2>();
//Repository<bool> data3 = new Repository<bool>();

//Repository<Bird1,Animal1> animal = new Repository<Bird1,Animal1>();