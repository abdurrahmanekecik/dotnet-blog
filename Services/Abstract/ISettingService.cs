using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entitites;

namespace DataAccess.Interfaces
{
    public interface ISettingService
    {
        Setting GetByUuid(Guid uuid);
        void Update(Setting role);
    }
}
