using Dapper;
using OffRoadVietNam.DAL.Interface;
using OffRoadVietNam.Domain.Request.Plan;
using OffRoadVietNam.Domain.Response.Plan;
using System;
using System.Data;
using System.Threading.Tasks;

namespace OffRoadVietNam.DAL.Implement
{
    public class PlanRepository : BaseRepository,IPlanRepository
    {
        public async Task<CreatePlanRes> Create(CreatePlanReq createPlanReq)
        {
            CreatePlanRes Result = new CreatePlanRes();

            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@PlaceName", createPlanReq.PlaceName);
                parameters.Add("@Title", createPlanReq.Title);
                parameters.Add("@LevelDifficult",createPlanReq.LevelDifficult);
                parameters.Add("@StartDate", createPlanReq.StartDate);
                parameters.Add("@EndDate", createPlanReq.EndDate);
                parameters.Add("@CreateBy", createPlanReq.CreateBy);
                parameters.Add("@CreateDate", createPlanReq.CreateDate);
                parameters.Add("@ModifiedBy", createPlanReq.ModifiedBy);
                parameters.Add("@ModifiedDate", createPlanReq.ModifiedDate);
                parameters.Add("@Status", createPlanReq.Status);

                Result = await SqlMapper.QueryFirstOrDefaultAsync<CreatePlanRes>(cnn: connection,
                                                                    sql: "sp_CreatePlan",
                                                                    param: parameters,
                                                                    commandType: CommandType.StoredProcedure);
                return Result;
            }
            catch (Exception)
            {
                return Result;
            }
        }
    }
}
