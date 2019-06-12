using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates SteamReader object called "steamReaderObject"
            //Assign its value to null
            StreamReader streamReaderObject = null; 

            try
            {
                //Assigns "streamReaderObject to read from a text file name "file1"
                streamReaderObject = new StreamReader("file1.txt");

                //Reads all characters from the current position to the end of the stream 
                //Stores in String variable "contents
                String contents = streamReaderObject.ReadToEnd();

                //Closes StreamReader
                streamReaderObject.Close();

                //Writes the amount of text elements in the text file to the console
                Console.WriteLine("The file has {0} text elements.", new StringInfo(contents).LengthInTextElements);
            }
            //code to handle any errors
            catch (FileNotFoundException)
            {
                //Informs user there is no file created
                Console.WriteLine("The file cannot be found");
            }

            //Invoking the Dispose method in a finally block
            //Note that code in finally block will always execute
            finally
            {
                //Checks if object is not null
                if(streamReaderObject != null)
                {
                    //Close StreamReader
                    streamReaderObject.Close();

                    //Calls upon the Dispose method
                    //Releases all resources used by the Text reader object
                    streamReaderObject.Dispose(); 
                }
            }
        }
    }
}
