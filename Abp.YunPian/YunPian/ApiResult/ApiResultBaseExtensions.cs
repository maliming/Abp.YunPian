namespace YunPian.ApiResult
{
    public static class ApiResultBaseExtensions
    {
        /// <summary>
        ///     系统返回码
        ///     http://www.yunpian.com/api2.0/api-recode.html
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool IsSucceed(this ApiResultBase result)
        {
            return result?.Http_Status_Code == 0;
        }
    }
}