using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Interfaces;
using Entitites;
using Services.Abstract;

namespace Services.Concrete
{
    public class SettingService : ISettingService
    {
        private readonly ISettingRepository _settingRepository;

        public SettingService(ISettingRepository settingRepository)
        {
            _settingRepository = settingRepository;
        }

        public Setting GetByUuid(Guid uuid)
        {
            return _settingRepository.GetByUuid(uuid);
        }

        public void Update(Setting setting)
        {
            _settingRepository.Update(setting);
        }
    }
}
