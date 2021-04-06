
using Maestro.Core.Interfaces.IAppRepo.INavLinkDefaultPermissionRepo;
using Maestro.Core.Interfaces.IAppRepo.INavLinkRepo;
using Maestro.Core.Interfaces.IAppRepo.INavPermissionRepo;
using Maestro.Core.Interfaces.IAppRepo.INavUserPermissionRepo;
using Maestro.Core.Interfaces.IAppRepo.IPermissionGroupRepo;
using Maestro.Core.Interfaces.IAppRepo.IPermissionRepo;
using Maestro.Core.Interfaces.IAppRepo.IUserGroupDefaultPermissionRepo;
using Maestro.Core.Interfaces.IAppRepo.IUserPermissionRepo;
using Maestro.Core.Interfaces.IAssetRepo.IAssetTypeRepo;
using Maestro.Core.Interfaces.IAssetRepo.IAssetTypeStatusRepo;
using Maestro.Core.Interfaces.IAssetRepo.IBaseDeviceRepo;
using Maestro.Core.Interfaces.IAssetRepo.IBaseDeviceStatusRepo;
using Maestro.Core.Interfaces.IChargesRepo.IChargeClassificationRepo;
using Maestro.Core.Interfaces.IChargesRepo.IChargeCodeRepo;
using Maestro.Core.Interfaces.IChargesRepo.IChargeStatusRepo;
using Maestro.Core.Interfaces.IChargesRepo.IChargeTypeRepo;
using Maestro.Core.Interfaces.IChargesRepo.IXREFChargesRepo;
using Maestro.Core.Interfaces.ICompanyRepo.IMainListRepo;
using Maestro.Core.Interfaces.IDepartmentRepo;
using Maestro.Core.Interfaces.IEDIRepo.ICarrierFileImportFieldsRepo;
using Maestro.Core.Interfaces.IEDIRepo.ICarrierFileRepo;
using Maestro.Core.Interfaces.IEDIRepo.IProcessTypesRepo;
using Maestro.Core.Interfaces.IEDIRepo.IProcessTypeStatusRepo;
using Maestro.Core.Interfaces.IGeneralRepo.IReleaseNotesRepo;
using Maestro.Core.Interfaces.IPaymentsRepo.IPaymentMethodRepo;
using Maestro.Core.Interfaces.IPaymentsRepo.IPaymentMethodStatusRepo;
using Maestro.Core.Interfaces.IPaymentsRepo.IPaymentTypesRepo;
using Maestro.Core.Interfaces.IServicesRepo.IServiceSubTypeRepo;
using Maestro.Core.Interfaces.IServicesRepo.IServiceSubTypeStatusRepo;
using Maestro.Core.Interfaces.IServicesRepo.IServiceTypeRepo;
using Maestro.Core.Interfaces.IServicesRepo.IServiceTypeStatusRepo;
using Maestro.Core.Interfaces.IUserRepo.IUserGroupRepo;
using Maestro.Core.Interfaces.IUserRepo.IUserProfileRepo;
using Maestro.Core.Interfaces.IUserRepo.IUsersInGroupRepo;
using Maestro.Core.Interfaces.IVendorsRepo.IVendorsRemitInfoRepo;
using Maestro.Core.Interfaces.IVendorsRepo.IVendorsRepo;
using Maestro.Core.Interfaces.IVendorsRepo.IVendorsStatusRepo;
using Maestro.Core.Interfaces.IWirelessRepo.IPlansRepo;
using Maestro.Core.Interfaces.IWirelessRepo.IPlanStatusRepo;
using Maestro.Core.Interfaces.IWirelessRepo.IPlanTypesRepo;
using Maestro.Infrastructure.CompanyRepo.CompanyCommands;
using Maestro.Infrastructure.CompanyRepo.CompanyQueries;
using Maestro.Infrastructure.Persistence.AppRepo.AppCommands;
using Maestro.Infrastructure.Persistence.AppRepo.AppQueries;
using Maestro.Infrastructure.Persistence.AssetRepo.AssetCommands;
using Maestro.Infrastructure.Persistence.AssetRepo.AssetQueries;
using Maestro.Infrastructure.Persistence.ChargesRepo.ChargesCommands;
using Maestro.Infrastructure.Persistence.ChargesRepo.ChargesQueries;
using Maestro.Infrastructure.Persistence.CompanyRepo.CompanyCommands;
using Maestro.Infrastructure.Persistence.CompanyRepo.CompanyQueries;
using Maestro.Infrastructure.Persistence.EDIRepo.EDICommands;
using Maestro.Infrastructure.Persistence.EDIRepo.EDIQueries;
using Maestro.Infrastructure.Persistence.GeneralRepo.GeneralCommands;
using Maestro.Infrastructure.Persistence.GeneralRepo.GeneralQueries;
using Maestro.Infrastructure.Persistence.PaymentsRepo.PaymentsCommands;
using Maestro.Infrastructure.Persistence.PaymentsRepo.PaymentsQueries;
using Maestro.Infrastructure.Persistence.ServicesRepo.ServicesCommands;
using Maestro.Infrastructure.Persistence.ServicesRepo.ServicesQueries;
using Maestro.Infrastructure.Persistence.UserRepo.UserCommands;
using Maestro.Infrastructure.Persistence.UserRepo.UserQueries;
using Maestro.Infrastructure.Persistence.VendorsRepo;
using Maestro.Infrastructure.Persistence.VendorsRepo.VendorsCommands;
using Maestro.Infrastructure.Persistence.VendorsRepo.VendorsQueries;
using Maestro.Infrastructure.Persistence.WirelessRepo.WirelessCommands;
using Maestro.Infrastructure.Persistence.WirelessRepo.WirelessQueries;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Maestro.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddMaestroInfrastructurePersistence(this IServiceCollection services)
        {
            //#region Maestro Infrastructure Shared 

            //services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            //services.AddTransient<IConnectionFactory, ConnectionFactory>();

            //services.AddTransient<IUnitOfWork, UnitOfWork>();

            //#endregion

            #region Repositories
            //Department
            services.AddTransient<IDepartmentQueryRepository, DepartmentQueryRepository>();
            services.AddTransient<IDepartmentCommandRepository, DepartmentCommandRepository>();

            services.AddTransient<IMainListQueryRepository, MainListQueryRepository>();
            services.AddTransient<IMainListCommandRepository, MainListCommandRepository>();


            // App
            services.AddTransient<INavLinkCommandRepository, NavLinkCommandRepository>();
            services.AddTransient<INavLinkQueryRepository, NavLinkQueryRepository>();

            services.AddTransient<INavLinkDefaultPermissionCommandRepository, NavLinkDefaultPermissionCommandRepository>();
            services.AddTransient<INavLinkDefaultPermissionQueryRepository, NavLinkDefaultPermissionQueryRepository>();
            services.AddTransient<INavPermissionCommandRepository, NavPermissionCommandRepository>();
            services.AddTransient<INavPermissionQueryRepository, NavPermissionQueryRepository>();

            services.AddTransient<INavUserPermissionCommandRepository, NavUserPermissionCommandRepository>();
            services.AddTransient<INavUserPermissionQueryRepository, NavUserPermissionQueryRepository>();

            services.AddTransient<IPermissionCommandRepository, PermissionCommandRepository>();
            services.AddTransient<IPermissionQueryRepository, PermissionQueryRepository>();

            services.AddTransient<IPermissionGroupCommandRepository, PermissionGroupCommandRepository>();
            services.AddTransient<IPermissionGroupQueryRepository, PermissionGroupQueryRepository>();

            services.AddTransient<IUserGroupDefaultPermissionCommandRepository, UserGroupDefaultPermissionCommandRepository>();
            services.AddTransient<IUserGroupDefaultPermissionQueryRepository, UserGroupDefaultPermissionQueryRepository>();

            services.AddTransient<IUserPermissionCommandRepository, UserPermissionCommandRepository>();
            services.AddTransient<IUserPermissionQueryRepository, UserPermissionQueryRepository>();

            //Asset
            services.AddTransient<IAssetTypeCommandRepository, AssetTypeCommandRepository>();
            services.AddTransient<IAssetTypeQueryRepository, AssetTypeQueryRepository>();

            services.AddTransient<IAssetTypeStatusCommandRepository, AssetTypeStatusCommandRepository>();
            services.AddTransient<IAssetTypeStatusQueryRepository, AssetTypeStatusQueryRepository>();

            services.AddTransient<IBaseDeviceQueryRepository, BaseDeviceQueryRepository>();
            services.AddTransient<IBaseDeviceCommandRepository, BaseDeviceCommandRepository>();

            services.AddTransient<IBaseDeviceStatusCommandRepository, BaseDeviceStatusCommandRepository>();
            services.AddTransient<IBaseDeviceStatusQueryRepository, BaseDeviceStatusQueryRepository>();


            //Charges
            services.AddTransient<IChargeClassificationCommandRepository, ChargeClassificationCommandRepository>();
            services.AddTransient<IChargeClassificationQueryRepository, ChargeClassificationQueryRepository>();

            services.AddTransient<IChargeCodeCommandRepository, ChargeCodeCommandRepository>();
            services.AddTransient<IChargeCodeQueryRepository, ChargeCodeQueryRepository>();

            services.AddTransient<IChargeStatusCommandRepository, ChargeStatusCommandRepository>();
            services.AddTransient<IChargeStatusQueryRepository, ChargeStatusQueryRepository>();

            services.AddTransient<IChargeTypeCommandRepository, ChargeTypeCommandRepository>();
            services.AddTransient<IChargeTypeQueryRepository, ChargeTypeQueryRepository>();

            services.AddTransient<IXREFChargesCommandRepository, XREFChargesCommandRepository>();
            services.AddTransient<IXREFChargesQueryRepository, XREFChargesQueryRepository>();



            //EDI
            services.AddTransient<ICarrierFileCommandRepository, CarrierFileCommandRepository>();
            services.AddTransient<ICarrierFileQueryRepository, CarrierFileQueryRepository>();

            services.AddTransient<ICarrierFileImportFieldsCommandRepository, CarrierFileImportFieldsCommandRepository>();
            services.AddTransient<ICarrierFileImportFieldsQueryRepository, CarrierFileImportFieldsQueryRepository>();

            services.AddTransient<IProcessTypesCommandRepository, ProcessTypesCommandRepository>();
            services.AddTransient<IProcessTypesQueryRepository, ProcessTypesQueryRepository>();

            services.AddTransient<IProcessTypeStatusCommandRepository, ProcessTypeStatusCommandRepository>();
            services.AddTransient<IProcessTypeStatusQueryRepository, ProcessTypeStatusQueryRepository>();


            //General
            services.AddTransient<IReleaseNotesCommandRepository, ReleaseNotesCommandRepository>();
            services.AddTransient<IReleaseNotesQueryRepository, ReleaseNotesQueryRepository>();



            //Payment
            services.AddTransient<IPaymentMethodCommandRepository, PaymentMethodCommandRepository>();
            services.AddTransient<IPaymentMethodQueryRepository, PaymentMethodQueryRepository>();

            services.AddTransient<IPaymentMethodStatusCommandRepository, PaymentMethodStatusCommandRepository>();
            services.AddTransient<IPaymentMethodStatusQueryRepository, PaymentMethodStatusQueryRepository>();

            services.AddTransient<IPaymentTypesCommandRepository, PaymentTypesCommandRepository>();
            services.AddTransient<IPaymentTypesQueryRepository, PaymentTypesQueryRepository>();

            services.AddTransient<IProcessTypeStatusCommandRepository, ProcessTypeStatusCommandRepository>();
            services.AddTransient<IProcessTypeStatusQueryRepository, ProcessTypeStatusQueryRepository>();



            //Services

            services.AddTransient<IServiceSubTypeCommandRepository, ServiceSubTypeCommandRepository>();
            services.AddTransient<IServiceSubTypeQueryRepository, ServiceSubTypeQueryRepository>();

            services.AddTransient<IServiceSubTypeStatusCommandRepository, ServiceSubTypeStatusCommandRepository>();
            services.AddTransient<IServiceSubTypeStatusQueryRepository, ServiceSubTypeStatusQueryRepository>();

            services.AddTransient<IServiceTypeCommandRepository, ServiceTypeCommandRepository>();
            services.AddTransient<IServiceTypeQueryRepository, ServiceTypeQueryRepository>();

            services.AddTransient<IServiceTypeStatusCommandRepository, ServiceTypeStatusCommandRepository>();
            services.AddTransient<IServiceTypeStatusQueryRepository, ServiceTypeStatusQueryRepository>();


            //User

            services.AddTransient<IUserGroupCommandRepository, UserGroupCommandRepository>();
            services.AddTransient<IUserGroupQueryRepository, UserGroupQueryRepository>();

            services.AddTransient<IUserProfileCommandRepository, UserProfileCommandRepository>();
            services.AddTransient<IUserProfileQueryRepository, UserProfileQueryRepository>();

            services.AddTransient<IUsersInGroupCommandRepository, UsersInGroupCommandRepository>();
            services.AddTransient<IUsersInGroupQueryRepository, UsersInGroupQueryRepository>();





            //Vendors
            services.AddTransient<IVendorsCommandRepository, VendorsCommandRepository>();
            services.AddTransient<IVendorsQueryRepository, VendorsQueryRepository>();

            services.AddTransient<IVendorRemitInfoQueryRepository, VendorRemitInfoQueryRepository>();
            services.AddTransient<IVendorRemitInfoCommandRepository, VendorRemitInfoComandRepository>();

            services.AddTransient<IVendorStatusQueryRepository, VendorStatusQueryRepository>();
            services.AddTransient<IVendorStatusCommandRepository, VendorStatusCommandRepository>();

            #endregion


            //Plans
            services.AddTransient<IPlansCommandRepository, PlansCommandRepository>();
            services.AddTransient<IPlansQueryRepository, PlansQueryRepository>();

            services.AddTransient<IPlanStatusCommandRepository, PlanStatusCommandRepository>();
            services.AddTransient<IPlanStatusQueryRepository, PlanStatusQueryRepository>();

            services.AddTransient<IPlanTypesCommandRepository, PlanTypesCommandRepository>();
            services.AddTransient<IPlanTypesQueryRepository, PlanTypesQueryRepository>();







            return services;

        }
    }
}
