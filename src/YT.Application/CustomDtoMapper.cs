using System.Configuration;
using AutoMapper;
using YT.Authorization.Users.Dto;
using YT.Managers.Users;

namespace YT
{
    /// <summary>
    /// dtoӳ�������ļ�
    /// </summary>
    internal static class CustomDtoMapper
    {
        private static volatile bool _mappedBefore;
        private static readonly object SyncObj = new object();
        private static readonly string Host = ConfigurationManager.AppSettings.Get("WebSiteRootAddress");
        public static void CreateMappings(IMapperConfigurationExpression mapper)
        {
            lock (SyncObj)
            {
                if (_mappedBefore)
                {
                    return;
                }

                CreateMappingsInternal(mapper);

                _mappedBefore = true;
            }
        }

        private static void CreateMappingsInternal(IMapperConfigurationExpression mapper)
        {
            mapper.CreateMap<User, UserEditDto>()
                .ForMember(dto => dto.Password, options => options.Ignore())
                .ReverseMap()
                .ForMember(user => user.Password, options => options.Ignore());

         
        }
    }
}