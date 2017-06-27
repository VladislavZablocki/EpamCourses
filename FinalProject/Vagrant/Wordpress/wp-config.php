<?php
/**
 * Основные параметры WordPress.
 *
 * Скрипт для создания wp-config.php использует этот файл в процессе
 * установки. Необязательно использовать веб-интерфейс, можно
 * скопировать файл в "wp-config.php" и заполнить значения вручную.
 *
 * Этот файл содержит следующие параметры:
 *
 * * Настройки MySQL
 * * Секретные ключи
 * * Префикс таблиц базы данных
 * * ABSPATH
 *
 * @link https://codex.wordpress.org/Editing_wp-config.php
 *
 * @package WordPress
 */

// ** Параметры MySQL: Эту информацию можно получить у вашего хостинг-провайдера ** //
/** Имя базы данных для WordPress */
define('DB_NAME', 'wordpress');

/** Имя пользователя MySQL */
define('DB_USER', 'wordpressuser');

/** Пароль к базе данных MySQL */
define('DB_PASSWORD', 'wordpresspass');

/** Имя сервера MySQL */
define('DB_HOST', '127.0.0.1');

/** Кодировка базы данных для создания таблиц. */
define('DB_CHARSET', 'utf8mb4');

/** Схема сопоставления. Не меняйте, если не уверены. */
define('DB_COLLATE', '');

/**#@+
 * Уникальные ключи и соли для аутентификации.
 *
 * Смените значение каждой константы на уникальную фразу.
 * Можно сгенерировать их с помощью {@link https://api.wordpress.org/secret-key/1.1/salt/ сервиса ключей на WordPress.org}
 * Можно изменить их, чтобы сделать существующие файлы cookies недействительными. Пользователям потребуется авторизоваться снова.
 *
 * @since 2.6.0
 */
define('AUTH_KEY',         'kj^gxoxEnR8p5&nPyPiEqxCA@q-a4zQ5YUH_IC;m(*U|ZECx&_TJvVtMgUWDrN*O');
define('SECURE_AUTH_KEY',  'N&{0DEO>.)/{G]|,#Lu7oJ:e{%wuL{ax&Qj1*Px03Sm %eNB1ys|CTqP8+zj=FLl');
define('LOGGED_IN_KEY',    'rFFFhF<-pi5=;4S_k5&lQH]Y$ETkd0:<8fX.qzT5CcE7pNm6{,zl.yvhyXpJdlK2');
define('NONCE_KEY',        'Vm: HlaKPL%yxtSZ|$y5/btG$Hz:iE1&M576<_$_J5s#,X%~os];}7HbLLW{AjB3');
define('AUTH_SALT',        '~R}mc<]zbQXVYz(by]$P 4e43F#}nWFJ}IS(owQLgiN-[4H24L<I2?OYU^oIDjif');
define('SECURE_AUTH_SALT', 'ta$m1)2xF.c&3V!%6m(/&0B6imBnf(:SIIxqzf__/)gL1Al~4l4:.OB:![T9+/d{');
define('LOGGED_IN_SALT',   'cGy?dq<K5beVN7aHQ]Y2p B)27sLXL2$Ve<zvirp+h*Xe$fz/dHIWhf)<{y[Wq+C');
define('NONCE_SALT',       'vxBy/4xwG)lE9vuaz|4OkBSg5m-jI}E^~^5Tz&=)QZj>^@#Fn+D:2`Lge]vR7aP2');

/**#@-*/

/**
 * Префикс таблиц в базе данных WordPress.
 *
 * Можно установить несколько сайтов в одну базу данных, если использовать
 * разные префиксы. Пожалуйста, указывайте только цифры, буквы и знак подчеркивания.
 */
$table_prefix  = 'wp_';

/**
 * Для разработчиков: Режим отладки WordPress.
 *
 * Измените это значение на true, чтобы включить отображение уведомлений при разработке.
 * Разработчикам плагинов и тем настоятельно рекомендуется использовать WP_DEBUG
 * в своём рабочем окружении.
 * 
 * Информацию о других отладочных константах можно найти в Кодексе.
 *
 * @link https://codex.wordpress.org/Debugging_in_WordPress
 */
define('WP_DEBUG', false);

/* Это всё, дальше не редактируем. Успехов! */

/** Абсолютный путь к директории WordPress. */
if ( !defined('ABSPATH') )
	define('ABSPATH', dirname(__FILE__) . '/');

/** Инициализирует переменные WordPress и подключает файлы. */
require_once(ABSPATH . 'wp-settings.php');
