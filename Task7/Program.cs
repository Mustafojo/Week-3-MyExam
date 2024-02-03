// Section 1
// List<int> list = new List<int>() { 1, 0, 5, -4, 5, 10, -80, 24, 0, -4, 100, 24, 45, 6, -1 };
// list.Sort();
// var lis = list.Max();
// System.Console.WriteLine(lis);


// Section 2
// List<int> list2 = new List<int>() { 1, 0, 5, -4, 5, 10, -80, 24, 0, -4, 100, 24, 45, 6, -1 };
// for (int i = 0; i < list2.Count(); i++)
// {
//     for (int j = 0; j < list2.Count; j++)
//     {
//         if(list2[i] == list2[j])
//         {
//             list2.Remove(i);
//         }
//     }
// }
// foreach (var item in list2)
// {
//     System.Console.Write(item + " ");
// }

// Section 3
// List<int> list3 = new List<int>() { 1, 0, 5, -4, 5, 10, -80, 24, 0, -4, 100, 24, 45, 6, -1 };
// list3.Sort();
// foreach (var item in list3)
// {
//     System.Console.WriteLine(item);
// }


// Section 4
List<int> list4 = new List<int>() { 1, 0, 5, -4, 5, 10, -80, 24, 0, -4, 100, 24, 45, 6, -1 };

for (int i = 0; i < list4.Count; i++)
{
    if(list4[i] < 0)
    {
        list4[i] = 0;
    }
}

foreach (var item in list4)
{
    System.Console.WriteLine(item);
}
