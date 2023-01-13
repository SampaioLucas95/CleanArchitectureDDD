using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionName.Contracts.Integracao
{
    public record ClientCotacao(
         string code,
         string codein,
         string name,
         string high,
         string low,
         string pctChange,
         string bid,
         string ask,
         string varBid,
         string timestamp,
         string create_date);
}
