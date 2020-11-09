using Dapper;
using OffRoadVietNam.DAL.Interface;
using OffRoadVietNam.Domain.Request.Plan;
using OffRoadVietNam.Domain.Response.Plan;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace OffRoadVietNam.DAL.Implement
{
    public class PlanRepository : BaseRepository, IPlanRepository
    {
        public async Task<SavePlanRes> ChangeStatus(ChangeStatusReq changeStatusReq)
        {
            SavePlanRes Result = new SavePlanRes();

            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@PlanId", changeStatusReq.PlanId);
                parameters.Add("@Status", changeStatusReq.Status);

                Result = await SqlMapper.QueryFirstOrDefaultAsync<SavePlanRes>(cnn: connection,
                                                                    sql: "sp_ChangeStatus",
                                                                    param: parameters,
                                                                    commandType: CommandType.StoredProcedure);
                return Result;
            }
            catch (Exception)
            {
                return Result;
            }
        }

        public async Task<SavePlanRes> Create(SavePlanReq createPlanReq)
        {
            SavePlanRes Result = new SavePlanRes();

            try
            {
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@PlanId", createPlanReq.PlanId);
                parameters.Add("@PlaceName", createPlanReq.PlaceName);
                parameters.Add("@Title", createPlanReq.Title);
                parameters.Add("@LevelDifficult", createPlanReq.LevelDifficult);
                parameters.Add("@StartDate", createPlanReq.StartDate);
                parameters.Add("@EndDate", createPlanReq.EndDate);
                parameters.Add("@CreateBy", createPlanReq.CreateBy);
                parameters.Add("@CreateDate", createPlanReq.CreateDate);
                parameters.Add("@ModifiedBy", createPlanReq.ModifiedBy);
                parameters.Add("@ModifiedDate", createPlanReq.ModifiedDate);
                parameters.Add("@Status", createPlanReq.Status);

                Result = await SqlMapper.QueryFirstOrDefaultAsync<SavePlanRes>(cnn: connection,
                                                                    sql: "sp_SavePlan",
                                                                    param: parameters,
                                                                    commandType: CommandType.StoredProcedure);
                return Result;
            }
            catch (Exception)
            {
                return Result;
            }
        }

        public async Task<IEnumerable<PlanView>> Gets()
        {
            return await SqlMapper.QueryAsync<PlanView>(cnn: connection,
                                                        sql: "sp_GetPlans",
                                                        commandType: CommandType.StoredProcedure);
        }
    }
}
