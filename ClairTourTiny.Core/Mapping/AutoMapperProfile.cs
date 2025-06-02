using AutoMapper;
using ClairTourTiny.Core.Models.ProjectMaintenance;
using ClairTourTiny.Core.Models.ProjectMaintenance.Save;
using ClairTourTiny.Core.Models.Projects;
using ClairTourTiny.Infrastructure.Dto.ProjectMaintenance;
using ClairTourTiny.Infrastructure.Dto.Projects;
using ClairTourTiny.Infrastructure.Models;

namespace ClairTourTiny.Core.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ProjectFavouriteDto, Models.Projects.Project>()
                .ForAllMembers(opts => opts.Condition((ProjectFavouriteDto src, Models.Projects.Project dest, object srcMember) => srcMember != null));
            CreateMap<ProjectRecentDto, Models.Projects.Project>()
                .ForMember<string>(dest => dest.DisplayOrder, opt => opt.MapFrom(src => src.DisplayOrder.ToString()))
                .ForMember<string>(dest => dest.GroupDisplayOrder, opt => opt.MapFrom(src => src.GroupDisplayOrder.ToString()))
                .ForAllMembers(opts => opts.Condition((ProjectRecentDto src, Models.Projects.Project dest, object srcMember) => srcMember != null));
            CreateMap<ProjectSearchDto, Models.Projects.Project>()
                .ForAllMembers(opts => opts.Condition((ProjectSearchDto src, Models.Projects.Project dest, object srcMember) => srcMember != null));

            CreateMap<PhaseDto, PhaseModel>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<Models.ProjectMaintenance.Save.ProjectModel, Pm2Project>()
            .ForMember(dest => dest.SessionId, opt => opt.MapFrom(src => 1));

            // Equipment mapping
            CreateMap<Equipment, Pm2Equipment>()
                .ForMember(dest => dest.SessionId, opt => opt.MapFrom(src => 1));

            // Crew mapping
            CreateMap<Crew, Pm2Crew>()
                .ForMember(dest => dest.SessionId, opt => opt.MapFrom(src => 1));

            // Assigned Crew mapping
            CreateMap<AssignedCrew, Pm2AssignedCrew>()
                .ForMember(dest => dest.SessionId, opt => opt.MapFrom(src => 1));

            // RFI mapping
            CreateMap<RfiModel, Pm2Rfi>()
                .ForMember(dest => dest.SessionId, opt => opt.MapFrom(src => 1));

            // Bid Expense mapping
            CreateMap<BidExpense, Pm2BidExpense>()
                .ForMember(dest => dest.SessionId, opt => opt.MapFrom(src => 1));

            // Bid Revenue mapping
            CreateMap<BidRevenue, Pm2BidRevenue>()
                .ForMember(dest => dest.SessionId, opt => opt.MapFrom(src => 1));

            // Project Note mapping
            CreateMap<ProjectNote, Pm2ProjectNote>()
                .ForMember(dest => dest.SessionId, opt => opt.MapFrom(src => 1));

            // Project Billing Period mapping
            CreateMap<Models.ProjectMaintenance.Save.ProjectBillingPeriod, Pm2ProjectBillingPeriod>()
                .ForMember(dest => dest.SessionId, opt => opt.MapFrom(src => 1));

            // Project Client Contact mapping
            CreateMap<ProjectClientContactModel, Pm2ProjectClientContact>()
                .ForMember(dest => dest.SessionId, opt => opt.MapFrom(src => 1));

            // Project Employee Overtime Rate mapping
            CreateMap<Models.ProjectMaintenance.Save.ProjectEmployeeOvertimeRate, Pm2ProjectEmployeeOvertimeRate>()
                .ForMember(dest => dest.SessionId, opt => opt.MapFrom(src => 1));

            // Project Billing Period Item mapping
            CreateMap<Models.ProjectMaintenance.Save.ProjectBillingPeriodItem, Pm2ProjectBillingPeriodItem>()
                .ForMember(dest => dest.SessionId, opt => opt.MapFrom(src => 1));

            // Project Production Schedule mapping
            CreateMap<ProjectProductionScheduleModel, Pm2ProjectProductionSchedule>()
                .ForMember(dest => dest.SessionId, opt => opt.MapFrom(src => 1));

            // Project Billing Item mapping
            CreateMap<ProjectBillingItemModel, Pm2ProjectBillingItem>()
                .ForMember(dest => dest.SessionId, opt => opt.MapFrom(src => 1));

            // Favorite Project mapping
            CreateMap<FavoriteProject, Pm2FavoriteProjects>()
                .ForMember(dest => dest.SessionId, opt => opt.MapFrom(src => 1));

            // Equipment Subhire mapping
            CreateMap<ProjectEquipmentSubhireModel, Pm2EquipmentSubhire>()
                .ForMember(dest => dest.SessionId, opt => opt.MapFrom(src => 1));

            CreateMap<EquipmentDto, ProjectEquipmentModel>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<EquipmentSubhireDto, ProjectEquipmentSubhireModel>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<BidExpenseDto, ProjectBidExpenseModel>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<RfiDto, ProjectRfiModel>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<NoteDto, ProjectNoteModel>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<AssignedCrewOtDto, ProjectAssignedCrewOtModel>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<BillingItemDto, ProjectBillingItemModel>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<PartBidValueDto, ProjectPartBidValueModel>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<ProductionScheduleDto, ProjectProductionScheduleModel>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<AssignedCrewDto, ProjectAssignedCrewModel>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<CrewDto, ProjectCrewModel>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<BillingPeriodDto, ProjectBillingPeriodModel>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<BillingPeriodItemDto, ProjectBillingPeriodItemModel>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<ClientShippingAddressDto, ProjectClientShippingAddressModel>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<PartDto, ProjectPartModel>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<ClientContactDto, ProjectClientContactModel>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<ClientAddressDto, ProjectClientAddressModel>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
} 