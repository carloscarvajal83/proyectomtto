namespace Coldairarrow.Entity.Base_SysManage
{
    /// <summary>
    /// 枚举类型
    /// </summary>
    public class EnumType
    {
        /// <summary>
        /// 系统日志类型
        /// </summary>
        public enum LogType
        {
            ExcepcionSistema,
            GestionUsuarios,
            GestionRoles,
            GestionClaves,
        }

        /// <summary>
        /// 系统角色类型
        /// </summary>
        public enum RoleType
        {
            SuperAdmin = 1,
        }
    }
}
