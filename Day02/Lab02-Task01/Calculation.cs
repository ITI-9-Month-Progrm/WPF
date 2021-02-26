using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

    

namespace Lab02_Task01
{
    public static class Calculation
    {
        
        static public string calcResult(string eq)
        {
            string result = " ";
            int flag;
            
            DataTable  dt = new DataTable();
            flag = syntaxErro(eq);
            if (flag == 0)
            {
                result = "Syntax Error";
            }
            else
            {
              var  resDT = dt.Compute(eq, " ");
                result =""+resDT;
            }
           
            return result;
        }
        static private int syntaxErro(string eq)
        {
            int flag = 1;
            int len = eq.Length;
            int op = 1, dot = 1;
            if (eq?.Length == 1 && (eq[0] == '+' || eq[0] == '-' || eq[0] == '*' || eq[0] == '/'))
            {
                flag = 0;
            }
            else if (eq?.Length != 1 && (eq[0] == '*' || eq[0] == '/'))
            {
                flag = 0;
            }
            else if(op == 1 || dot == 1)
            {
                for(int i=0; i < len; i++)
                {
                    op = checkTwoOperator(eq, i);
                    if (op == 0) { flag = 0;break; }
                    else
                    {
                        dot = checkDotOperator(eq, i);
                        if (dot == 0) { flag = 0;break; }
                    }
                }
            }
            return flag;
        }
        static private int checkTwoOperator(string eq,int index)
        {
            int flag = 1; // if 0 -> found two operator if 1 -> not found
            if (eq[index] == '+' && ( eq[index+1] == '+' || eq[index+1] == '-' || eq[index+1] == '*' || eq[index+1] == '/'))
            {
                flag = 0;
            }
            if (eq[index] == '-' && ( eq[index + 1] == '+' || eq[index + 1] == '-' || eq[index + 1] == '*' || eq[index + 1] == '/'))
            {
                flag = 0;
            }
            if (eq[index] == '*' && ( eq[index + 1] == '+' || eq[index + 1] == '-' || eq[index + 1] == '*' || eq[index + 1] == '/'))
            {
                flag = 0;
            }
            if (eq[index] == '/' && ( eq[index + 1] == '+' || eq[index + 1] == '-' || eq[index + 1] == '*' || eq[index + 1] == '/'))
            {
                flag = 0;
            }
            
            return flag;
        }
        static private int checkDotOperator(string eq, int index)
        {
            int flag = 1; // if 0 -> found .. if 1 -> not found
            if(eq[index] == '.' && eq[index + 1] == '.')
            {
                flag = 0;
            }
            return flag;
        }
    }
}
