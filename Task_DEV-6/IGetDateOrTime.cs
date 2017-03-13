namespace task_DEV_6
{
    interface IGetDateOrTime
    {
        /// <summary>
        /// method which return string with date or time in user format
        /// </summary>
        /// <param name="format">user format</param>
        /// <returns>date or time</returns>
        string GetInFormat(string format);
    }
}
