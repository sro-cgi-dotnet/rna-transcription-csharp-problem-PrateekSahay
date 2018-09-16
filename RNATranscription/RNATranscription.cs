using System;
using System.Text;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide){
            /* 
            string rna="";
            foreach(char nuc in nucleotide){
                 switch(nuc){
                    case 'G':
                            rna += "C";
                            break;
                    case 'C':
                            rna += "G";
                            break;
                    case 'T':
                            rna += "A";
                            break;
                    case 'A':
                            rna += "U";
                            break;
                   
                }
            }
            
            return rna;
        }
        */
        //Using StringBuilder

        StringBuilder rna = new StringBuilder();
            foreach(char nuc in nucleotide){
                switch(nuc){
                    case 'G':
                            rna.Append("C");
                            break;
                    case 'C':
                            rna.Append("G");
                            break;
                    case 'T':
                            rna.Append("A");
                            break;
                    case 'A':
                            rna.Append("U");
                            break;
                }
            }
            return rna.ToString();
        }
    }
}
