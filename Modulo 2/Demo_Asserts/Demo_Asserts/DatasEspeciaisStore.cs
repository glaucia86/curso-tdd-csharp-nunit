using System;

namespace Demo_Asserts
{
    /* Classe genérica que armazena datas especiais */
    public class DatasEspeciaisStore
    {
        /* Retornar uma determinada data especial */
        public DateTime Data(DatasEspeciais datasEspeciais)
        {
            switch (datasEspeciais)
            {
                case DatasEspeciais.AnoNovo:
                    // 01/01/2017 0:00:00
                    return new DateTime(2017,1,1,0,0,0,0);
                
                //case DatasEspeciais.AniversarioRiodeJaneiro:
                //    return new DateTime(2017,21,1,0,0,0,0);

                default:
                    throw new ArgumentOutOfRangeException("datasEspeciais");
            }
        }
    }
}
