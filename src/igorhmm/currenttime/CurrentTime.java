package igorhmm.currenttime;

import java.text.SimpleDateFormat;
import java.util.Calendar;
	 
/**
 * Class to determine current system time 
 */	 
public class CurrentTime {
	/**
	 * Returns current system time in given format
	 * @param  timeFormat Desirable format for current time output
	 * @return current time
	 */	 
	static public String getTime(String timeFormat) {
        Calendar calendar = Calendar.getInstance();
        SimpleDateFormat simpleDateFormat = new SimpleDateFormat(timeFormat);
        return simpleDateFormat.format(calendar.getTime());
   	}
}