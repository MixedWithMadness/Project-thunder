using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PQDIFNet;

namespace PQtest2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ulong numbers = new ulong();
            int index = new int();
            Guid guide = new Guid();
            string name = "";
            int number1 = new int();
            int number2 = new int();
            int number3 = new int();
            int number4 = new int();

            //for (int i = 0; i < pqdif.RecordCount; i++)
            //{
            //    if(pqdif.GetTagName(i) = pqdif.get)
            //}

            bool go = true;
            CPQDIFNet pqdif = new CPQDIFNet();
            CPQDIFNet pqdif2 = new CPQDIFNet();

            while (go)
            {
                string input = Console.ReadLine();
                input = input.ToLower();
                input = input.Trim();

                int val = 0;

                if (Int32.TryParse(input, out val))
                {
                    Console.WriteLine(input);

                    switch (val)
                    {
                        case 1:
                            if (pqdif.New()) { Console.WriteLine("true"); }

                            pqdif.FlatFileName = "20021014-093938.pqd"; //20021017-093317.pqd
                            pqdif.Read();
                            if (pqdif.Read())
                            {
                                Console.WriteLine("Success");
                                Console.WriteLine(pqdif.RecordGetInfo(4, ref guide, ref name, ref number1, ref number2, ref number3, ref number4));
                                Console.WriteLine(guide + " | " + name + " | " + number1 + " | " + number2 + " | " + number3 + " | " + number4);
                                Console.WriteLine(pqdif.RecordGetInfo(5, ref guide, ref name, ref number1, ref number2, ref number3, ref number4));
                                Console.WriteLine(guide + " | " + name + " | " + number1 + " | " + number2 + " | " + number3 + " | " + number4);
                                
                            }
                            else
                            {
                                Console.WriteLine("Couldnt open.");
                            }
                            
                            if (pqdif.Close()) { Console.WriteLine("true"); }
                            break;

                        case 2:
                            if (pqdif2.New()) { Console.WriteLine("true"); }
                            pqdif2.FlatFileName = "20021017-093317.pqd"; //20021014-093938.pqd
                            if (pqdif2.Read())
                            {
                                Console.WriteLine("Success");
                                Console.WriteLine(pqdif2.RecordGetInfo(4, ref guide, ref name, ref number1, ref number2, ref number3, ref number4));
                                Console.WriteLine(guide + " | " + name + " | " + number1 + " | " + number2 + " | " + number3 + " | " + number4);
                                Console.WriteLine(pqdif.RecordGetInfo(5, ref guide, ref name, ref number1, ref number2, ref number3, ref number4));
                                Console.WriteLine(guide + " | " + name + " | " + number1 + " | " + number2 + " | " + number3 + " | " + number4);
                                

                            }
                            else
                            {
                                Console.WriteLine("Couldnt open.");
                            }
                            if (pqdif.Close()) { Console.WriteLine("true"); }
                            break;

                        case 3:

                            if (pqdif.New()) { Console.WriteLine("New: Success"); } else { Console.WriteLine("new: fail"); }

                            pqdif.FlatFileName = "20021014-093938.pqd"; //20021017-093317.pqd
                             
                            if (pqdif.Read())
                            {
                                Console.WriteLine("Read: success");
                                if (pqdif.RecordRequestDataSource(1, ref numbers))
                                {
                                    Console.WriteLine("Request data source: success");
                                }
                                else
                                {
                                    Console.WriteLine("Request data source: fail");
                                }

                                Console.WriteLine(numbers.ToString());
                                if (pqdif.RecordRequestDataSource(1, ref numbers))
                                {
                                    Console.WriteLine("Request data source: success");
                                }
                                else
                                {
                                    Console.WriteLine("Request data source: fail");
                                }

                                Console.WriteLine(numbers.ToString());
                                if (pqdif.RecordRequestDataSource(1, ref numbers))
                                {
                                    Console.WriteLine("Request data source: success");
                                }
                                else
                                {
                                    Console.WriteLine("Request data source: fail");
                                }

                                Console.WriteLine(numbers.ToString());
                                if (pqdif.RecordRequestDataSource(1, ref numbers))
                                {
                                    Console.WriteLine("Request data source: success");
                                }
                                else
                                {
                                    Console.WriteLine("Request data source: fail");
                                }

                                Console.WriteLine(numbers.ToString());
                            }
                            else
                            {
                                Console.WriteLine("Read: fail");
                            }

                            if(pqdif.Close()) { Console.WriteLine("Read: success"); } else { Console.WriteLine("Read: Fail"); }
                            break;

                        case 4:

                                if (pqdif.New()) { Console.WriteLine("New: Success"); } else { Console.WriteLine("new: fail"); }

                                pqdif.FlatFileName = "20021014-093938.pqd"; //20021017-093317.pqd
                                
                                if (pqdif.Read())
                                {
                                Console.WriteLine("Read: success");
                            }
                            else
                            {
                                Console.WriteLine("Read: Fail");
                            }

                                break;

                        case 9:
                            go = false;
                            break;
                    }
                }
            }
            


            //pqdif.RecordGetCollection(11,ref numbers);
            //Console.WriteLine(pqdif.GetTagName(1));

            //for (int i = 0; i < 1; /*pqdif.TagCount;*/ i++)
            //{
            //    //Console.WriteLine(pqdif.GetTagName(i));


            //}





            //pqdif.RecordGetInfo(1, ref guide, ref name, ref number1, ref number2, ref number3, ref number4);
            //Console.WriteLine(guide.ToString() + name + number1 + number2 + number3 + number4);

            Console.Read();
        }
    }
}
