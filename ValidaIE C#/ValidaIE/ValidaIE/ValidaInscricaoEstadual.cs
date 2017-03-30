using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValidaIE
{
    class ValidaInscricaoEstadual
    {
        public static void Main(string[] args)
        {
            /* Acre */
            Console.WriteLine("Inscrição Estadual AC {0}", ValidarInscricaoEstadual("AC", "01.000.941/001-24") ? "válido" : "inválido");
            Console.WriteLine("Inscrição Estadual AC {0}\n", ValidarInscricaoEstadual("AC", "01.011.544/001-94") ? "válido" : "inválido");
            /* Alagoas */
            Console.WriteLine("Inscrição Estadual AL {0}\n", ValidarInscricaoEstadual("AL", "24000004-8") ? "válido" : "inválido");
            /* Amazonas */
            Console.WriteLine("Inscrição Estadual AM {0}", ValidarInscricaoEstadual("AM", "041171616") ? "válido" : "inválido");
            Console.WriteLine("Inscrição Estadual AM {0}\n", ValidarInscricaoEstadual("AM", "04.210.308-8") ? "válido" : "inválido");
            /* Amapá */
            Console.WriteLine("Inscrição Estadual AP {0}\n", ValidarInscricaoEstadual("AP", "030123453") ? "válido" : "inválido");
            /* Bahia */
            Console.WriteLine("Inscrição Estadual BA {0} (inscricao com 8 digitos)", ValidarInscricaoEstadual("BA", "123456-63") ? "válido" : "inválido");
            Console.WriteLine("Inscrição Estadual BA {0} (inscricao com 9 digitos)\n", ValidarInscricaoEstadual("BA", "1000003-06") ? "válido" : "inválido");
            /* Ceará */
            Console.WriteLine("Inscrição Estadual CE {0}\n", ValidarInscricaoEstadual("CE", "06000001-5") ? "válido" : "inválido");
            /* Distrito Federal */
            Console.WriteLine("Inscrição Estadual DF {0}\n", ValidarInscricaoEstadual("DF", "07300001001-09") ? "válido" : "inválido");
            /* Espírito Santo */
            Console.WriteLine("Inscrição Estadual ES {0}\n", ValidarInscricaoEstadual("ES", "99999999-0") ? "válido" : "inválido");
            /* Goiás */
            Console.WriteLine("Inscrição Estadual GO {0}\n", ValidarInscricaoEstadual("GO", "10.987.654-7") ? "válido" : "inválido");
            /* Maranhão */
            Console.WriteLine("Inscrição Estadual MA {0}\n", ValidarInscricaoEstadual("MA", "120000385") ? "válido" : "inválido");
            /* Mato Grosso */
            Console.WriteLine("Inscrição Estadual MT {0}\n", ValidarInscricaoEstadual("MT", "0013000001-9") ? "válido" : "inválido");
            /* Mato Grosso do Sul */
            Console.WriteLine("Inscrição Estadual MS {0}\n", ValidarInscricaoEstadual("MS", "283115947") ? "válido" : "inválido");
            /* Minas Gerais */
            Console.WriteLine("Inscrição Estadual MG {0}\n", ValidarInscricaoEstadual("MG", "062.307.904/0081") ? "válido" : "inválido");
            /* Pará */
            Console.WriteLine("Inscrição Estadual PA {0}\n", ValidarInscricaoEstadual("PA", "15-999999-5") ? "válido" : "inválido");
            /* Paraíba */
            Console.WriteLine("Inscrição Estadual PB {0}\n", ValidarInscricaoEstadual("PB", "06000001-5") ? "válido" : "inválido");
            /* Pernambuco */
            Console.WriteLine("Inscrição Estadual PE {0}\n", ValidarInscricaoEstadual("PE", "0321418-40") ? "válido" : "inválido");
            /* Piauí */
            Console.WriteLine("Inscrição Estadual PI {0}\n", ValidarInscricaoEstadual("PI", "012345679") ? "válido" : "inválido");
            /* Paraná */
            Console.WriteLine("Inscrição Estadual PR {0}\n", ValidarInscricaoEstadual("PR", "123.45678-50") ? "válido" : "inválido");
            /* Rio de Janeiro */
            Console.WriteLine("Inscrição Estadual RJ {0}\n", ValidarInscricaoEstadual("RJ", "99.999.99-3") ? "válido" : "inválido");
            /* Rio Grande do Norte */
            Console.WriteLine("Inscrição Estadual RN {0} (inscricao com 9 digitos)", ValidarInscricaoEstadual("RN", "20.040.040-1") ? "válido" : "inválido");
            Console.WriteLine("Inscrição Estadual RN {0} (inscricao com 10 digitos)\n", ValidarInscricaoEstadual("RN", "20.0.040.040-0") ? "válido" : "inválido");
            /* Rondônia */
            Console.WriteLine("Inscrição Estadual RO {0}\n", ValidarInscricaoEstadual("RO", "000.62521-3") ? "válido" : "inválido");
            /* Rio Grande do Sul */
            Console.WriteLine("Inscrição Estadual RS {0}\n", ValidarInscricaoEstadual("RS", "224/3658792") ? "válido" : "inválido");
            /* Santa Catarina */
            Console.WriteLine("Inscrição Estadual SC {0}\n", ValidarInscricaoEstadual("SC", "251.040.852 ") ? "válido" : "inválido");
            /* Sergipe */
            Console.WriteLine("Inscrição Estadual SE {0}\n", ValidarInscricaoEstadual("SE", "27123456-3 ") ? "válido" : "inválido");
            /* São Paulo */
            Console.WriteLine("Inscrição Estadual SP {0}", ValidarInscricaoEstadual("SP", "110.042.490.114") ? "válido" : "inválido");
            Console.WriteLine("Inscrição Estadual SP {0}\n", ValidarInscricaoEstadual("SP", "P-01100424.3/002") ? "válido" : "inválido");
            /* Tocantins */
            Console.WriteLine("Inscrição Estadual TO {0}\n", ValidarInscricaoEstadual("TO", "290102278-36") ? "válido" : "inválido");

            System.Threading.Thread.Sleep(10000);

        }

        public static bool ValidarInscricaoEstadual(string pUF, string pInscr)
        {
            bool retorno = false;
            string strBase;
            string strBase2;
            string strOrigem;
            string strDigito1;
            string strDigito2;
            int intPos;
            int intValor;
            int intSoma = 0;
            int intResto;
            int intNumero;
            int intPeso = 0;

            strBase = "";
            strBase2 = "";
            strOrigem = "";
            
            if ((pInscr.Trim().ToUpper() == "ISENTO"))
                return true;

            for (intPos = 1; intPos <= pInscr.Trim().Length; intPos++)
            {
                if ((("0123456789P".IndexOf(pInscr.Substring((intPos - 1), 1), 0, System.StringComparison.OrdinalIgnoreCase) + 1) > 0))
                    strOrigem = (strOrigem + pInscr.Substring((intPos - 1), 1));
            }

            switch (pUF.ToUpper())
            {
                case "AC":
                    #region

                    strBase = (strOrigem.Trim() + "00000000000").Substring(0, 11);

                    if (strBase.Substring(0, 2) == "01")
                    {
                        intSoma = 0;
                        intPeso = 4;

                        for (intPos = 1; (intPos <= 11); intPos++)
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));

                            if (intPeso == 1) intPeso = 9;

                            intSoma += intValor * intPeso;

                            intPeso--;
                        }

                        intResto = (intSoma % 11);
                        strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));

                        intSoma = 0;
                        strBase = (strOrigem.Trim() + "000000000000").Substring(0, 12);
                        intPeso = 5;

                        for (intPos = 1; (intPos <= 12); intPos++)
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));

                            if (intPeso == 1) intPeso = 9;

                            intSoma += intValor * intPeso;
                            intPeso--;
                        }

                        intResto = (intSoma % 11);
                        strDigito2 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));

                        strBase2 = (strBase.Substring(0, 12) + strDigito2);

                        if ((strBase2 == strOrigem))
                            retorno = true;
                    }
                    #endregion

                    break;

                case "AL":

                    #region

                    strBase = (strOrigem.Trim() + "000000000").Substring(0, 9);

                    if ((strBase.Substring(0, 2) == "24"))
                    {
                        //24000004-8
                        //98765432
                        intSoma = 0;
                        intPeso = 9;

                        for (intPos = 1; (intPos <= 8); intPos++)
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                        
                            intSoma += intValor * intPeso;
                            intPeso--;
                        }

                        intSoma = (intSoma * 10);
                        intResto = (intSoma % 11);

                        strDigito1 = ((intResto == 10) ? "0" : Convert.ToString(intResto)).Substring((((intResto == 10) ? "0" : Convert.ToString(intResto)).Length - 1));

                        strBase2 = (strBase.Substring(0, 8) + strDigito1);

                        if ((strBase2 == strOrigem))
                            retorno = true;
                    }

                    #endregion

                    break;

                case "AM": 

                    #region
                    strBase = (strOrigem.Trim() + "000000000").Substring(0, 9);
                    intSoma = 0;
                    intPeso = 9;

                    for (intPos = 1; (intPos <= 8); intPos++)
                    {
                        intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                        
                        intSoma += intValor * intPeso;
                        intPeso--;
                    }

                    intResto = (intSoma % 11);

                    if (intSoma < 11)
                        strDigito1 = (11 - intSoma).ToString();
                    else
                        strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
                    
                    strBase2 = (strBase.Substring(0, 8) + strDigito1);

                    if ((strBase2 == strOrigem))
                        retorno = true;
                    #endregion

                    break;

                case "AP":

                    #region

                    strBase = (strOrigem.Trim() + "000000000").Substring(0, 9);
                    intPeso = 9;

                    if ((strBase.Substring(0, 2) == "03"))
                    {
                        strBase = (strOrigem.Trim() + "000000000").Substring(0, 9);
                        intSoma = 0;

                        for (intPos = 1; (intPos <= 8); intPos++)
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));

                            intSoma += intValor * intPeso;
                            intPeso--;
                        }

                        intResto = (intSoma % 11);
                        intValor = (11 - intResto);
                        
                        strDigito1 = Convert.ToString(intValor).Substring((Convert.ToString(intValor).Length - 1));

                        strBase2 = (strBase.Substring(0, 8) + strDigito1);

                        if ((strBase2 == strOrigem))
                            retorno = true;
                    }

                    #endregion

                    break;

                case "BA":

                    #region

                    if (strOrigem.Length == 8)
                        strBase = (strOrigem.Trim() + "00000000").Substring(0, 8);
                    else if (strOrigem.Length == 9)
                        strBase = (strOrigem.Trim() + "00000000").Substring(0, 9);

                    if ((("0123458".IndexOf(strBase.Substring(0, 1), 0, System.StringComparison.OrdinalIgnoreCase) + 1) > 0) && strBase.Length == 8)
                    {
                        #region

                        intSoma = 0;

                        for (intPos = 1; (intPos <= 6); intPos++)
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));

                            if (intPos == 1) intPeso = 7;

                            intSoma += intValor * intPeso;
                            intPeso--;
                        }


                        intResto = (intSoma % 10);
                        strDigito2 = ((intResto == 0) ? "0" : Convert.ToString((10 - intResto))).Substring((((intResto == 0) ? "0" : Convert.ToString((10 - intResto))).Length - 1));


                        strBase2 = strBase.Substring(0, 7) + strDigito2;

                        if (strBase2 == strOrigem)
                            retorno = true;

                        if (retorno)
                        {
                            intSoma = 0;
                            intPeso = 0;

                            for (intPos = 1; (intPos <= 7); intPos++)
                            {
                                intValor = int.Parse(strBase.Substring((intPos - 1), 1));

                                if (intPos == 7)
                                    intValor = int.Parse(strBase.Substring((intPos), 1));

                                if (intPos == 1) intPeso = 8;

                                intSoma += intValor * intPeso;
                                intPeso--;
                            }


                            intResto = (intSoma % 10);
                            strDigito1 = ((intResto == 0) ? "0" : Convert.ToString((10 - intResto))).Substring((((intResto == 0) ? "0" : Convert.ToString((10 - intResto))).Length - 1));

                            strBase2 = (strBase.Substring(0, 6) + strDigito1 + strDigito2);

                            if ((strBase2 == strOrigem))
                                retorno = true;
                        }

                        #endregion
                    }
                    else if ((("679".IndexOf(strBase.Substring(0, 1), 0, System.StringComparison.OrdinalIgnoreCase) + 1) > 0) && strBase.Length == 8)
                    {
                        #region

                        intSoma = 0;

                        for (intPos = 1; (intPos <= 6); intPos++)
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));

                            if (intPos == 1) intPeso = 7;

                            intSoma += intValor * intPeso;
                            intPeso--;
                        }


                        intResto = (intSoma % 11);
                        strDigito2 = ((intResto == 0) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto == 0) ? "0" : Convert.ToString((11 - intResto))).Length - 1));


                        strBase2 = strBase.Substring(0, 7) + strDigito2;

                        if (strBase2 == strOrigem)
                            retorno = true;

                        if (retorno)
                        {
                            intSoma = 0;
                            intPeso = 0;

                            for (intPos = 1; (intPos <= 7); intPos++)
                            {
                                intValor = int.Parse(strBase.Substring((intPos - 1), 1));

                                if (intPos == 7)
                                    intValor = int.Parse(strBase.Substring((intPos), 1));

                                if (intPos == 1) intPeso = 8;

                                intSoma += intValor * intPeso;
                                intPeso--;
                            }


                            intResto = (intSoma % 11);
                            strDigito1 = ((intResto == 0) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto == 0) ? "0" : Convert.ToString((11 - intResto))).Length - 1));

                            strBase2 = (strBase.Substring(0, 6) + strDigito1 + strDigito2);

                            if ((strBase2 == strOrigem))
                                retorno = true;
                        }

                        #endregion
                    }
                    else if ((("0123458".IndexOf(strBase.Substring(1, 1), 0, System.StringComparison.OrdinalIgnoreCase) + 1) > 0) && strBase.Length == 9)
                    {
                        #region
                        /* Segundo digito */
                        //1000003
                        //8765432
                        intSoma = 0;

                        
                        for (intPos = 1; (intPos <= 7); intPos++)
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));

                            if (intPos == 1) intPeso = 8;

                            intSoma += intValor * intPeso;
                            intPeso--;
                        }

                        intResto = (intSoma % 10);
                        strDigito2 = ((intResto == 0) ? "0" : Convert.ToString((10 - intResto))).Substring((((intResto == 0) ? "0" : Convert.ToString((10 - intResto))).Length - 1));

                        strBase2 = strBase.Substring(0, 8) + strDigito2;

                        if (strBase2 == strOrigem)
                            retorno = true;

                        if (retorno)
                        {
                            //1000003 6
                            //9876543 2
                            intSoma = 0;
                            intPeso = 0;
                            
                            for (intPos = 1; (intPos <= 8); intPos++)
                            {
                                intValor = int.Parse(strBase.Substring((intPos - 1), 1));

                                if (intPos == 8)
                                    intValor = int.Parse(strBase.Substring((intPos), 1));

                                if (intPos == 1) intPeso = 9;

                                intSoma += intValor * intPeso;
                                intPeso--;
                            }


                            intResto = (intSoma % 10);
                            strDigito1 = ((intResto == 0) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto == 0) ? "0" : Convert.ToString((11 - intResto))).Length - 1));

                            strBase2 = (strBase.Substring(0, 7) + strDigito1 + strDigito2);

                            if ((strBase2 == strOrigem))
                                retorno = true;
                        }

                        #endregion
                    }

                    #endregion

                    break;

                case "CE": 

                    #region

                    strBase = (strOrigem.Trim() + "000000000").Substring(0, 9);
                    intSoma = 0;

                    for (intPos = 1; (intPos <= 8); intPos++)
                    {
                        intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                        intValor = (intValor * (10 - intPos));
                        intSoma = (intSoma + intValor);
                    }

                    intResto = (intSoma % 11);
                    intValor = (11 - intResto);

                    if ((intValor > 9))
                        intValor = 0;

                    strDigito1 = Convert.ToString(intValor).Substring((Convert.ToString(intValor).Length - 1));

                    strBase2 = (strBase.Substring(0, 8) + strDigito1);

                    if ((strBase2 == strOrigem))
                        retorno = true;

                    #endregion

                    break;

                case "DF":

                    #region

                    strBase = (strOrigem.Trim() + "0000000000000").Substring(0, 13);

                    if ((strBase.Substring(0, 3) == "073"))
                    {
                        intSoma = 0;
                        intPeso = 2;

                        for (intPos = 11; (intPos >= 1); intPos = (intPos + -1))
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                            intValor = (intValor * intPeso);
                            intSoma = (intSoma + intValor);
                            intPeso = (intPeso + 1);

                            if ((intPeso > 9))
                                intPeso = 2;
                        }

                        intResto = (intSoma % 11);
                        strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
                        strBase2 = (strBase.Substring(0, 11) + strDigito1);
                        intSoma = 0;
                        intPeso = 2;

                        for (intPos = 12; (intPos >= 1); intPos = (intPos + -1))
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                            intValor = (intValor * intPeso);
                            intSoma = (intSoma + intValor);
                            intPeso = (intPeso + 1);

                            if ((intPeso > 9))
                                intPeso = 2;
                        }

                        intResto = (intSoma % 11);
                        strDigito2 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
                        strBase2 = (strBase.Substring(0, 12) + strDigito2);

                        if ((strBase2 == strOrigem))
                            retorno = true;
                    }

                    #endregion

                    break;

                case "ES":

                    #region

                    strBase = (strOrigem.Trim() + "000000000").Substring(0, 9);
                    intSoma = 0;

                    for (intPos = 1; (intPos <= 8); intPos++)
                    {
                        intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                        intValor = (intValor * (10 - intPos));
                        intSoma = (intSoma + intValor);
                    }

                    intResto = (intSoma % 11);
                    strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
                    strBase2 = (strBase.Substring(0, 8) + strDigito1);

                    if ((strBase2 == strOrigem))
                        retorno = true;

                    #endregion

                    break;

                case "GO":

                    #region

                    strBase = (strOrigem.Trim() + "000000000").Substring(0, 9);

                    if ((("10,11,15".IndexOf(strBase.Substring(0, 2), 0, System.StringComparison.OrdinalIgnoreCase) + 1) > 0))
                    {
                        intSoma = 0;

                        for (intPos = 1; (intPos <= 8); intPos++)
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                            intValor = (intValor * (10 - intPos));
                            intSoma = (intSoma + intValor);
                        }

                        intResto = (intSoma % 11);

                        if ((intResto == 0))
                            strDigito1 = "0";
                        else if ((intResto == 1))
                        {
                            intNumero = int.Parse(strBase.Substring(0, 8));
                            strDigito1 = (((intNumero >= 10103105) && (intNumero <= 10119997)) ? "1" : "0").Substring(((((intNumero >= 10103105) && (intNumero <= 10119997)) ? "1" : "0").Length - 1));
                        }
                        else
                            strDigito1 = Convert.ToString((11 - intResto)).Substring((Convert.ToString((11 - intResto)).Length - 1));

                        strBase2 = (strBase.Substring(0, 8) + strDigito1);

                        if ((strBase2 == strOrigem))
                            retorno = true;
                    }

                    #endregion

                    break;

                case "MA":

                    #region

                    strBase = (strOrigem.Trim() + "000000000").Substring(0, 9);

                    if ((strBase.Substring(0, 2) == "12"))
                    {
                        intSoma = 0;

                        for (intPos = 1; (intPos <= 8); intPos++)
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                            intValor = (intValor * (10 - intPos));
                            intSoma = (intSoma + intValor);
                        }

                        intResto = (intSoma % 11);
                        strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
                        strBase2 = (strBase.Substring(0, 8) + strDigito1);

                        if ((strBase2 == strOrigem))
                            retorno = true;
                    }

                    #endregion

                    break;

                case "MT":
                    #region

                    strBase = (strOrigem.Trim() + "0000000000").Substring(0, 10);
                    intSoma = 0;
                    intPeso = 2;

                    for (intPos = 10; intPos >= 1; intPos = (intPos + -1))
                    {
                        intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                        intValor = (intValor * intPeso);
                        intSoma = (intSoma + intValor);
                        intPeso = (intPeso + 1);

                        if ((intPeso > 9))
                            intPeso = 2;
                    }

                    intResto = (intSoma % 11);
                    strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
                    strBase2 = (strBase.Substring(0, 10) + strDigito1);

                    if ((strBase2 == strOrigem))
                        retorno = true;

                    #endregion

                    break;
                case "MS":
                    #region

                    strBase = (strOrigem.Trim() + "000000000").Substring(0, 9);

                    if ((strBase.Substring(0, 2) == "28"))
                    {
                        intSoma = 0;

                        for (intPos = 1; (intPos <= 8); intPos++)
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                            intValor = (intValor * (10 - intPos));
                            intSoma = (intSoma + intValor);
                        }

                        intResto = (intSoma % 11);
                        strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
                        strBase2 = (strBase.Substring(0, 8) + strDigito1);

                        if ((strBase2 == strOrigem))
                            retorno = true;
                    }

                    #endregion

                    break;

                case "MG":

                    #region

                    strBase = (strOrigem.Trim() + "0000000000000").Substring(0, 13);
                    strBase2 = (strBase.Substring(0, 3) + ("0" + strBase.Substring(3, 8)));
                    intNumero = 2;

                    string strSoma = "";

                    for (intPos = 1; (intPos <= 12); intPos++)
                    {
                        intValor = int.Parse(strBase2.Substring((intPos - 1), 1));
                        intNumero = ((intNumero == 2) ? 1 : 2);
                        intValor = (intValor * intNumero);
                        
                        intSoma = (intSoma + intValor);
                        strSoma += intValor.ToString();
                    }

                    intSoma = 0;

                    //Soma -se os algarismos, não o produto
                    for (int i = 0; i < strSoma.Length; i++)
                    {
                        intSoma += int.Parse(strSoma.Substring(i, 1));
                    }

                    intValor = int.Parse(strBase.Substring(8 , 2));
                    strDigito1 = (intValor - intSoma).ToString();

                    strBase2 = (strBase.Substring(0, 11) + strDigito1);

                    if ((strBase2 == strOrigem.Substring(0, 12)))
                        retorno = true;

                    if (retorno)
                    {
                        intSoma = 0;
                        intPeso = 3;

                        for (intPos = 1; (intPos <= 12); intPos++)
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));

                            if (intPeso < 2)
                                intPeso = 11;
                            
                            intSoma += (intValor * intPeso);
                            intPeso--;
                        }

                        intResto = (intSoma % 11);
                        intValor = 11 - intResto;
                        strDigito2 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));

                        strBase2 = (strBase.Substring(0, 12) + strDigito2);

                        if (strBase2 == strOrigem)
                            retorno = true;
                    }
                    
                    #endregion

                    break;

                case "PA":

                    #region

                    strBase = (strOrigem.Trim() + "000000000").Substring(0, 9);

                    if ((strBase.Substring(0, 2) == "15"))
                    {
                        intSoma = 0;

                        for (intPos = 1; (intPos <= 8); intPos++)
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                            intValor = (intValor * (10 - intPos));
                            intSoma = (intSoma + intValor);
                        }

                        intResto = (intSoma % 11);
                        strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
                        strBase2 = (strBase.Substring(0, 8) + strDigito1);

                        if ((strBase2 == strOrigem))
                            retorno = true;
                    }

                    #endregion

                    break;

                case "PB":

                    #region

                    strBase = (strOrigem.Trim() + "000000000").Substring(0, 9);
                    intSoma = 0;

                    for (intPos = 1; (intPos <= 8); intPos++)
                    {
                        intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                        intValor = (intValor * (10 - intPos));
                        intSoma = (intSoma + intValor);
                    }

                    intResto = (intSoma % 11);
                    intValor = (11 - intResto);

                    if ((intValor > 9))
                        intValor = 0;

                    strDigito1 = Convert.ToString(intValor).Substring((Convert.ToString(intValor).Length - 1));
                    strBase2 = (strBase.Substring(0, 8) + strDigito1);

                    if ((strBase2 == strOrigem))
                        retorno = true;

                    #endregion

                    break;

                case "PE":
                    #region

                    strBase = (strOrigem.Trim() + "00000000000000").Substring(0, 14);
                    intSoma = 0;
                    intPeso = 2;

                    for (intPos = 7; (intPos >= 1); intPos = (intPos + -1))
                    {
                        intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                        intValor = (intValor * intPeso);
                        intSoma = (intSoma + intValor);
                        intPeso = (intPeso + 1);

                        if ((intPeso > 9))
                            intPeso = 2;
                    }

                    intResto = (intSoma % 11);
                    intValor = (11 - intResto);

                    if ((intValor > 9))
                        intValor = (intValor - 10);

                    strDigito1 = Convert.ToString(intValor).Substring((Convert.ToString(intValor).Length - 1));
                    strBase2 = (strBase.Substring(0, 7) + strDigito1);

                    if ((strBase2 == strOrigem.Substring(0,8)))
                        retorno = true;

                    if (retorno)
                    {
                        intSoma = 0;
                        intPeso = 2;

                        for (intPos = 8; (intPos >= 1); intPos = (intPos + -1))
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                            intValor = (intValor * intPeso);
                            intSoma = (intSoma + intValor);
                            intPeso = (intPeso + 1);

                            if ((intPeso > 9))
                                intPeso = 2;
                        }

                        intResto = (intSoma % 11);
                        intValor = (11 - intResto);

                        if ((intValor > 9))
                            intValor = (intValor - 10);

                        strDigito2 = Convert.ToString(intValor).Substring((Convert.ToString(intValor).Length - 1));
                        strBase2 = (strBase.Substring(0, 8) + strDigito2);

                        if ((strBase2 == strOrigem))
                            retorno = true;
                    }

                    #endregion

                    break;

                case "PI":
                    #region

                    strBase = (strOrigem.Trim() + "000000000").Substring(0, 9);
                    intSoma = 0;

                    for (intPos = 1; (intPos <= 8); intPos++)
                    {
                        intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                        intValor = (intValor * (10 - intPos));
                        intSoma = (intSoma + intValor);
                    }

                    intResto = (intSoma % 11);
                    strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
                    strBase2 = (strBase.Substring(0, 8) + strDigito1);

                    if ((strBase2 == strOrigem))
                        retorno = true;

                    #endregion

                    break;

                case "PR":
                    #region

                    strBase = (strOrigem.Trim() + "0000000000").Substring(0, 10);
                    intSoma = 0;
                    intPeso = 2;

                    for (intPos = 8; (intPos >= 1); intPos = (intPos + -1))
                    {
                        intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                        intValor = (intValor * intPeso);
                        intSoma = (intSoma + intValor);
                        intPeso = (intPeso + 1);

                        if ((intPeso > 7))
                            intPeso = 2;
                    }

                    intResto = (intSoma % 11);
                    strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
                    strBase2 = (strBase.Substring(0, 8) + strDigito1);
                    intSoma = 0;
                    intPeso = 2;

                    for (intPos = 9; (intPos >= 1); intPos = (intPos + -1))
                    {
                        intValor = int.Parse(strBase2.Substring((intPos - 1), 1));
                        intValor = (intValor * intPeso);
                        intSoma = (intSoma + intValor);
                        intPeso = (intPeso + 1);

                        if ((intPeso > 7))
                            intPeso = 2;
                    }

                    intResto = (intSoma % 11);
                    strDigito2 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
                    strBase2 = (strBase2 + strDigito2);

                    if ((strBase2 == strOrigem))
                        retorno = true;

                    #endregion

                    break;

                case "RJ":
                    #region

                    strBase = (strOrigem.Trim() + "00000000").Substring(0, 8);
                    intSoma = 0;
                    intPeso = 2;

                    for (intPos = 7; (intPos >= 1); intPos = (intPos + -1))
                    {
                        intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                        intValor = (intValor * intPeso);
                        intSoma = (intSoma + intValor);
                        intPeso = (intPeso + 1);

                        if ((intPeso > 7))
                            intPeso = 2;
                    }

                    intResto = (intSoma % 11);
                    strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
                    strBase2 = (strBase.Substring(0, 7) + strDigito1);

                    if ((strBase2 == strOrigem))
                        retorno = true;

                    #endregion

                    break;

                case "RN": //Verficar com 10 digitos
                    #region

                    if (strOrigem.Length == 9)
                        strBase = (strOrigem.Trim() + "000000000").Substring(0, 9);
                    else if (strOrigem.Length == 10)
                        strBase = (strOrigem.Trim() + "000000000").Substring(0, 10);

                    if ((strBase.Substring(0, 2) == "20") && strBase.Length == 9)
                    {
                        intSoma = 0;

                        for (intPos = 1; (intPos <= 8); intPos++)
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                            intValor = (intValor * (10 - intPos));
                            intSoma = (intSoma + intValor);
                        }

                        intSoma = (intSoma * 10);
                        intResto = (intSoma % 11);
                        strDigito1 = ((intResto > 9) ? "0" : Convert.ToString(intResto)).Substring((((intResto > 9) ? "0" : Convert.ToString(intResto)).Length - 1));
                        strBase2 = (strBase.Substring(0, 8) + strDigito1);

                        if ((strBase2 == strOrigem))
                            retorno = true;
                    }
                    else if (strBase.Length == 10)
                    {
                        intSoma = 0;

                        for (intPos = 1; (intPos <= 9); intPos++)
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                            intValor = (intValor * (11 - intPos));
                            intSoma = (intSoma + intValor);
                        }

                        intSoma = (intSoma * 10);
                        intResto = (intSoma % 11);
                        strDigito1 = ((intResto > 10) ? "0" : Convert.ToString(intResto)).Substring((((intResto > 10) ? "0" : Convert.ToString(intResto)).Length - 1));
                        strBase2 = (strBase.Substring(0, 9) + strDigito1);

                        if ((strBase2 == strOrigem))
                            retorno = true;
                    }

                    #endregion

                    break;

                case "RO":

                    strBase = (strOrigem.Trim() + "000000000").Substring(0, 9);
                    strBase2 = strBase.Substring(3, 5);
                    intSoma = 0;

                    for (intPos = 1; (intPos <= 5); intPos++)
                    {
                        intValor = int.Parse(strBase2.Substring((intPos - 1), 1));
                        intValor = (intValor * (7 - intPos));
                        intSoma = (intSoma + intValor);
                    }

                    intResto = (intSoma % 11);
                    intValor = (11 - intResto);

                    if ((intValor > 9))
                        intValor = (intValor - 10);

                    strDigito1 = Convert.ToString(intValor).Substring((Convert.ToString(intValor).Length - 1));
                    strBase2 = (strBase.Substring(0, 8) + strDigito1);

                    if ((strBase2 == strOrigem))
                        retorno = true;

                    break;

                case "RR":
                    #region

                    strBase = (strOrigem.Trim() + "000000000").Substring(0, 9);

                    if ((strBase.Substring(0, 2) == "24"))
                    {
                        intSoma = 0;

                        for (intPos = 1; (intPos <= 8); intPos++)
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                            intValor = intValor * intPos;
                            intSoma += intValor;
                        }

                        intResto = (intSoma % 9);
                        strDigito1 = Convert.ToString(intResto).Substring((Convert.ToString(intResto).Length - 1));
                        strBase2 = (strBase.Substring(0, 8) + strDigito1);

                        if ((strBase2 == strOrigem))
                            retorno = true;
                    }

                    #endregion

                    break;

                case "RS":
                    #region

                    strBase = (strOrigem.Trim() + "0000000000").Substring(0, 10);
                    intNumero = int.Parse(strBase.Substring(0, 3));

                    if (((intNumero > 0) && (intNumero < 468)))
                    {
                        intSoma = 0;
                        intPeso = 2;

                        for (intPos = 9; (intPos >= 1); intPos = (intPos + -1))
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                            intValor = (intValor * intPeso);
                            intSoma = (intSoma + intValor);
                            intPeso = (intPeso + 1);

                            if ((intPeso > 9))
                                intPeso = 2;
                        }

                        intResto = (intSoma % 11);
                        intValor = (11 - intResto);

                        if ((intValor > 9))
                            intValor = 0;

                        strDigito1 = Convert.ToString(intValor).Substring((Convert.ToString(intValor).Length - 1));
                        strBase2 = (strBase.Substring(0, 9) + strDigito1);

                        if ((strBase2 == strOrigem))
                            retorno = true;
                    }

                    #endregion

                    break;

                case "SC":
                    #region

                    strBase = (strOrigem.Trim() + "000000000").Substring(0, 9);
                    intSoma = 0;

                    for (intPos = 1; (intPos <= 8); intPos++)
                    {
                        intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                        intValor = (intValor * (10 - intPos));
                        intSoma = (intSoma + intValor);
                    }

                    intResto = (intSoma % 11);
                    strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
                    strBase2 = (strBase.Substring(0, 8) + strDigito1);

                    if ((strBase2 == strOrigem))
                        retorno = true;
                    #endregion

                    break;

                case "SE":
                    #region

                    strBase = (strOrigem.Trim() + "000000000").Substring(0, 9);
                    intSoma = 0;

                    for (intPos = 1; (intPos <= 8); intPos++)
                    {
                        intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                        intValor = (intValor * (10 - intPos));
                        intSoma = (intSoma + intValor);
                    }

                    intResto = (intSoma % 11);
                    intValor = (11 - intResto);

                    if ((intValor > 9))
                        intValor = 0;

                    strDigito1 = Convert.ToString(intValor).Substring((Convert.ToString(intValor).Length - 1));
                    strBase2 = (strBase.Substring(0, 8) + strDigito1);

                    if ((strBase2 == strOrigem))
                        retorno = true;

                    #endregion

                    break;

                case "SP":
                    #region

                    if ((strOrigem.Substring(0, 1) == "P"))
                    {
                        strBase = (strOrigem.Trim() + "0000000000000").Substring(0, 13);
                        strBase2 = strBase.Substring(1, 8);
                        intSoma = 0;
                        intPeso = 1;

                        for (intPos = 1; (intPos <= 8); intPos++)
                        {
                            intValor = int.Parse(strBase.Substring((intPos), 1));
                            intValor = (intValor * intPeso);
                            intSoma = (intSoma + intValor);
                            intPeso = (intPeso + 1);

                            if ((intPeso == 2))
                                intPeso = 3;

                            if ((intPeso == 9))
                                intPeso = 10;
                        }

                        intResto = (intSoma % 11);
                        strDigito1 = Convert.ToString(intResto).Substring((Convert.ToString(intResto).Length - 1));
                        strBase2 = (strBase.Substring(0, 9) + (strDigito1 + strBase.Substring(10, 3)));
                    }
                    else
                    {
                        strBase = (strOrigem.Trim() + "000000000000").Substring(0, 12);
                        intSoma = 0;
                        intPeso = 1;

                        for (intPos = 1; (intPos <= 8); intPos++)
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                            intValor = (intValor * intPeso);
                            intSoma = (intSoma + intValor);
                            intPeso = (intPeso + 1);

                            if ((intPeso == 2))
                                intPeso = 3;

                            if ((intPeso == 9))
                                intPeso = 10;
                        }

                        intResto = (intSoma % 11);
                        strDigito1 = Convert.ToString(intResto).Substring((Convert.ToString(intResto).Length - 1));
                        strBase2 = (strBase.Substring(0, 8) + (strDigito1 + strBase.Substring(9, 2)));
                        intSoma = 0;
                        intPeso = 2;

                        for (intPos = 11; (intPos >= 1); intPos = (intPos + -1))
                        {
                            intValor = int.Parse(strBase.Substring((intPos - 1), 1));
                            intValor = (intValor * intPeso);
                            intSoma = (intSoma + intValor);
                            intPeso = (intPeso + 1);

                            if ((intPeso > 10))
                                intPeso = 2;
                        }

                        intResto = (intSoma % 11);
                        strDigito2 = Convert.ToString(intResto).Substring((Convert.ToString(intResto).Length - 1));
                        strBase2 = (strBase2 + strDigito2);
                    }

                    if ((strBase2 == strOrigem))
                        retorno = true;

                    #endregion

                    break;

                case "TO":
                    #region

                    strBase = (strOrigem.Trim() + "00000000000").Substring(0, 11);

                    if ((("01,02,03,99".IndexOf(strBase.Substring(2, 2), 0, System.StringComparison.OrdinalIgnoreCase) + 1) > 0))
                    {
                        strBase2 = (strBase.Substring(0, 2) + strBase.Substring(4, 6));
                        intSoma = 0;

                        for (intPos = 1; (intPos <= 8); intPos++)
                        {
                            intValor = int.Parse(strBase2.Substring((intPos - 1), 1));
                            intValor = (intValor * (10 - intPos));
                            intSoma = (intSoma + intValor);
                        }

                        intResto = (intSoma % 11);
                        strDigito1 = ((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Substring((((intResto < 2) ? "0" : Convert.ToString((11 - intResto))).Length - 1));
                        strBase2 = (strBase.Substring(0, 10) + strDigito1);

                        if ((strBase2 == strOrigem))
                            retorno = true;
                    }

                    #endregion

                    break;

            }

            return retorno;
        }
    }
}
