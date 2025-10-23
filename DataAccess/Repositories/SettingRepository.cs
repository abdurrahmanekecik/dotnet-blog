using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Interfaces;
using Entitites;

namespace DataAccess.Repositories
{
    public class SettingRepository : ISettingRepository
    {
        private readonly Context _context;

        public SettingRepository(Context context)
        {
            _context = context;
        }

        public Setting GetByUuid(Guid uuid)
        {
            return _context.Settings.FirstOrDefault(x => x.Uuid == uuid);
        }

        public void Update(Setting settings)
        {
            _context.Settings.Update(settings);
            _context.SaveChanges();
        }
    }
}
