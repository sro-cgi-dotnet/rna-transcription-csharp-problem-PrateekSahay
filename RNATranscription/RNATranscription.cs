using System;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
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
    }
}
