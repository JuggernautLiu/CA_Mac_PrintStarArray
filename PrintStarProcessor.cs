using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Mac_PrintStarArray
{
    public class PrintStarProcessor
    {
        public void Init(ref string[,] arrays, int count)
        {
            arrays = new string[count,count];
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    arrays[i,j] = " ";
                }                 
                
            }
        }

        public void GenerateStar(ref string[,] arrays)
        {
            int XLen = arrays.GetLength(0);
            int YLen = arrays.GetLength(1);
            if(XLen == YLen && (XLen%2!=0))
            {
                int middleIndex = 0 + (XLen / 2);
                for (int x = 0; x < XLen; x++)
                {
                    int bias = (int)Math.Abs(middleIndex - x);
                    int star_begin = middleIndex - (middleIndex - bias);
                    int star_end = middleIndex + (middleIndex - bias);
                    
                    for (int i = star_begin; i <= star_end; i++)
                    {
                        arrays[x,i] = "*";
                    }
                }   

            }

        }

        public string GetPrintString(string[,] arrays)
        {
            int XLen = arrays.GetLength(0);
            int YLen = arrays.GetLength(1);
            StringBuilder SB = new StringBuilder();
            for (int x = 0; x < XLen; x++)
            {
                for (int y = 0; y < YLen; y++)
                {
                    SB.Append(arrays[x,y]);
                }                 
                SB.Append("\n");
            }
            return SB.ToString();
        }

        
    }
}