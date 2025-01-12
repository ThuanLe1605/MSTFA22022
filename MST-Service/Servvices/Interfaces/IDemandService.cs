﻿using MST_Service.RequestModels.Create;
using MST_Service.RequestModels.Update;
using MST_Service.ViewModels;

namespace MST_Service.Servvices.Interfaces
{
    public interface IDemandService
    {
        Task<IEnumerable<DemandViewModel>> GetDemands(string? search,Guid? genderId, Guid? subjectId, Guid? gradeId, Guid? syllabusId);
        Task<DemandViewModel> GetDemand(Guid id);
        Task<IEnumerable<LectureViewModel>> GetRecommendLecture(Guid demandId);
        Task<DemandViewModel> CreateDemand(DemandCreateModel demand);
        Task<DemandViewModel> UpdateDemand(Guid id, DemandUpdateModel demand);
        Task<bool> RemoveDemand(Guid id);
    }
}
