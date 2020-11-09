using Dapper;
using OffRoadVietNam.DAL.Interface;
using OffRoadVietNam.Domain.Request.PlanMember;
using OffRoadVietNam.Domain.Response.PlanMember;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace OffRoadVietNam.DAL.Implement
{
    public class PlanMemberRepository : BaseRepository,IPlanMemberRepository
    {
        public async Task<JoinMemberRes> Create(JoinPlanReq joinPlanReq)
        {
            JoinMemberRes Result = new JoinMemberRes();

            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@PlanId", joinPlanReq.PlanId);
                parameters.Add("@MemberId", joinPlanReq.MemberId);

                Result = await SqlMapper.QueryFirstOrDefaultAsync<JoinMemberRes>(cnn: connection,
                                                                    sql: "sp_CreatePlanMember",
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
