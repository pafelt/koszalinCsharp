using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp_Basics
{
    [TestFixture]
    public class StringsAndItsOperations
    {
        /// <summary>
        /// String is diffrent then previues types we talk about
        /// values of string we are passing in quotation marks
        /// 
        /// Create new string with your name and then add them together
        /// </summary>
        //    [Test]
        //    public void Bascis_Of_Strings()
        //    {
        //string Name = "Patryk Afelt";
        //string Example = "This is example string";

        //string Value = Example + " " + Name;
        //Console.WriteLine(Value);
        //Assert.AreEqual(Value, "This is example string Patryk Afelt");
        //    }

        //        /// <summary>
        //        ///  string is first Reference Type you see (We will talk more about them later)
        //        ///  which means he doesn't have to have value.
        //        ///  use string.Empty;
        //        ///  create new strings itsEmpty and make it empty
        //        /// </summary>
        //[Test]
        //public void String_Initialization()
        //{
        //    ////int x = 6;
        //    ////int y = 5;
        //    ////string errorMessage = "There was error with operation values \n" + x + "and" + y;
        //    ////string errorMessageFormat = string.Format("There was error with operation values \n{0} and {1}", x, y);
        //    ////string errorMessageFormatDollar = $"There was error with operation values \n{x} and {y}";

        //    ////Console.WriteLine(errorMessage);
        //    ////Console.WriteLine(errorMessageFormat);
        //    ////Console.WriteLine(errorMessageFormatDollar);

        //    string itsEmpty = string.Empty;


        //    Assert.That(itsEmpty, Is.Not.Null);
        //}

        //        /// <summary>
        //        /// + is not best way of adding string
        //        ///  use string.Concat();
        //        ///  put sentence together
        //        /// </summary>
        //[Test]
        //public void Adding_String()
        //{
        //    string first = "pancakes.";
        //    string second = "I like";

        //    string resault = string.Concat(second, " ", first); 

        //    Assert.AreEqual(resault, "I like pancakes.");
        //}

        //        /// <summary>
        //        /// There is few more ways of cosntructing strings for example if you need add values of other variables inside you can do
        //        /// https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netframework-4.7.1#Starting
        //        /// create string with both x and y insed
        //        /// </summary>
        //[Test]
        //public void String_Format()
        //{
        //    int x = 500;
        //    int y = 453;
        //    string result = $"{x}, {y}";

        //   StringAssert.Contains(x.ToString(), result);
        //   StringAssert.Contains(y.ToString(), result);

        //}

        //        /// <summary>
        //        /// From theString return word "thing".
        //        /// hint use Substring() method
        //        /// </summary>
        //[Test]
        //public void Substrings()
        //{
        //    var theString =
        //        "The interesting thing about London is that there are always stylish surprises around every corner.";

        //    int searchid = theString.IndexOf("thing");
        //    string result = theString.Substring(searchid,5);

        //    Assert.AreEqual("thing",result);
        //}
    }
}
