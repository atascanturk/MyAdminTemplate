using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MyWebsite.Business.Abstract;
using MyWebsite.Business.Concrete;
using MyWebsite.Business.ServiceAdapters;
using MyWebsite.Core.Utilities.Interceptors;
using MyWebsite.DataAccess.Abstract;
using MyWebsite.DataAccess.Concrete.EntityFramework.Contexts;
using MyWebsite.DataAccess.Concrete.EntityFramework.Repositories;
using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // base.Load(builder);
            builder.RegisterType<AdministrativeStaffManager>().As<IAdministrativeStaffService>().SingleInstance();
            builder.RegisterType<EfAdministrativeStaffDal>().As<IAdministrativeStaffDal>().SingleInstance();

            builder.RegisterType<AnnouncementManager>().As<IAnnouncementService>().SingleInstance();
            builder.RegisterType<EfAnnouncementDal>().As<IAnnouncementDal>().SingleInstance();

            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<ImageManager>().As<IImageService>().SingleInstance();
            builder.RegisterType<EfImageDal>().As<IImageDal>().SingleInstance();

            builder.RegisterType<MusicManager>().As<IMusicService>().SingleInstance();
            builder.RegisterType<EfMusicDal>().As<IMusicDal>().SingleInstance();

            builder.RegisterType<NewsManager>().As<INewsService>().SingleInstance();
            builder.RegisterType<EfNewsDal>().As<INewsDal>().SingleInstance();

            builder.RegisterType<SliderManager>().As<ISliderService>().SingleInstance();
            builder.RegisterType<EfSliderDal>().As<ISliderDal>().SingleInstance();

            builder.RegisterType<SocialMediaManager>().As<ISocialMediaService>().SingleInstance();
            builder.RegisterType<EfSocialMediaDal>().As<ISocialMediaDal>().SingleInstance();

            builder.RegisterType<ContactManager>().As<IContactService>().SingleInstance();
            builder.RegisterType<EfContactDal>().As<IContactDal>().SingleInstance();

            builder.RegisterType<MaintenanceCheckManager>().As<IMaintenanceCheckService>().SingleInstance();
            builder.RegisterType<EfMaintenanceCheckDal>().As<IMaintenanceCheckDal>().SingleInstance();

            builder.RegisterType<MemberManager>().As<IMemberService>().SingleInstance();
            builder.RegisterType<EfMemberDal>().As<IMemberDal>().SingleInstance();

            builder.RegisterType<MernisServiceAdapter>().As<IUserCheckService>().SingleInstance();

            builder.RegisterType<MyDbContext>().AsSelf().As<IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
