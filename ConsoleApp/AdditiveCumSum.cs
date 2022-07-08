using System.Collections.Generic;


namespace ConsoleApp
{
    public class AdditiveCumSum
    {
        private int Number { get; set; }
        public AdditiveCumSum(int number)
        {
            this.Number = number;
        }

        private List<int> Listn()
        {
            List<int> ages = new List<int>();

            for (int i = 1; i <= Number; i++)
            {
                ages.Add(i);
            }
            return ages;
        }
        private bool checkLen(List<int> checkList)
        {
            if (checkList.Count > 1)
                return true;

            else
                return false;
        }
        private string DropLastValue(string listStr)
        {
            return listStr[0..(listStr.Length - 1)];
        }

        private string ListToSeries(List<int> aList)
        {
            AdditiveCumSum add = new AdditiveCumSum(Number);
            string valueStr = "";
            foreach (var item in aList)
            {
                valueStr = valueStr + " " + item.ToString() + "+";
            }
            return add.DropLastValue(valueStr);
        }

        public void AdditiveSum()
        {
            AdditiveCumSum add = new AdditiveCumSum(Number);
            List<int> listInt = new List<int>();

            foreach (var item in add.Listn())
            {
                listInt.Add(item);
                Console.WriteLine(add.ListToSeries(listInt));

                if (add.checkLen(listInt) == true)
                {
                    listInt.Add(item);
                    Console.WriteLine(add.ListToSeries(listInt));
                }

                else
                {
                    listInt.Add(item);
                    Console.WriteLine(add.ListToSeries(listInt));
                }
            }
        }
    }
}