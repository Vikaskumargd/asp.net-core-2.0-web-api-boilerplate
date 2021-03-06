﻿using AutoMapper;
using SalesApi.Models.Overall;
using SalesApi.Models.Retail;
using SalesApi.Models.Settings;
using SalesApi.ViewModels.Overall;
using SalesApi.ViewModels.Retail;
using SalesApi.ViewModels.Settings;

namespace SalesApi.Web.Configurations
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName => "ViewModelToDomainMappings";

        public ViewModelToDomainMappingProfile()
        {
            #region Settings

            CreateMap<VehicleViewModel, Vehicle>();
            CreateMap<DistributionGroupViewModel, DistributionGroup>();
            CreateMap<DeliveryVehicleViewModel, DeliveryVehicle>();
            CreateMap<SubAreaAddViewModel, SubArea>();
            CreateMap<SubAreaEditViewModel, SubArea>();
            CreateMap<ProductViewModel, Product>();

            #endregion

            #region Overall

            CreateMap<SalesDayViewModel, SalesDay>();

            #endregion

            #region Retail

            CreateMap<ProductForRetailViewModel, ProductForRetail>();
            CreateMap<RetailerViewModel, Retailer>();
            CreateMap<RetailPromotionSeriesBonusViewModel, RetailPromotionSeriesBonus>();
            CreateMap<RetailPromotionEventViewModel, RetailPromotionEvent>();
            CreateMap<RetailPromotionEventBonusViewModel, RetailPromotionEventBonus>();
            CreateMap<RetailPromotionSeriesAddViewModel, RetailPromotionSeries>();
            CreateMap<RetailPromotionSeriesEditViewModel, RetailPromotionSeries>();
            CreateMap<RetailDayViewModel, RetailDay>();
            CreateMap<RetailProductSnapshotViewModel, RetailProductSnapshot>();

            #endregion
        }
    }
}