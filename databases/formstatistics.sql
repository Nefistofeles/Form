-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 06 Eyl 2020, 23:59:50
-- Sunucu sürümü: 10.4.13-MariaDB
-- PHP Sürümü: 7.4.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `formstatistics`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `form`
--

CREATE TABLE `form` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `name` varchar(40) NOT NULL,
  `tag` varchar(40) NOT NULL,
  `information` text NOT NULL,
  `isActive` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `form`
--

INSERT INTO `form` (`id`, `name`, `tag`, `information`, `isActive`) VALUES
(1, 'Uyuşturucu1', 'uyuşturucu1', 'Uyuşturucu bağımlılığı hakkında1', 0),
(2, 'Uyuşturucu', 'uyuşturucu', 'Uyuşturucu bağımlılığı hakkında', 1);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `question`
--

CREATE TABLE `question` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `question_string` text NOT NULL,
  `form_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `question`
--

INSERT INTO `question` (`id`, `question_string`, `form_id`) VALUES
(3, 'Alkollü içecekleri ne sıklıkta kullanırsınız?', 2),
(5, 'Alkol aldığınız zaman günde kaç standart içki içersiniz?', 2),
(6, 'Bir seferde 6 veya daha fazla standart içki içme sıklığınız?', 2),
(7, 'Geçtiğimiz yıl içinde kaç kez içmeye başladıktan sonra alkol alımını durduramadınız?', 2),
(8, 'Geçen yıl içinde alkollü içki içmeniz nedeniyle normalde sizden bekleneni yapmakta kaç kez başarısız oldunuz?', 2),
(9, 'Geçen yıl fazla alkollü içki içtiğiniz bir gecenin sabahında kendinize gelebilmek için alkollü bir içki almanız kaç kez gerekti?', 2),
(10, 'Geçen yıl kaç kez alkollü bir içki içtikten sonra suçluluk veya pişmanlık duyduğunuz oldu?', 2),
(11, 'deneme formu sorusu', 3),
(14, 'sjhdasd', 1);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `question_option`
--

CREATE TABLE `question_option` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `option_string` text NOT NULL,
  `point` int(11) NOT NULL,
  `question_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `question_option`
--

INSERT INTO `question_option` (`id`, `option_string`, `point`, `question_id`) VALUES
(1, 'adada', 50, 1),
(2, 'ccc', 30, 1),
(3, 'ccc', 10, 1),
(4, 'ccc', 10, 1),
(5, 'merhaba1', 10, 1),
(6, 'ccc', 25, 2),
(7, 'Hiçbir zaman', 50, 3),
(8, 'Ayda bir veya daha az', 30, 3),
(9, 'Hiçbir zaman', 50, 3),
(10, 'Ayda bir veya daha az', 30, 3),
(11, 'Haftada bir veya daha az', 20, 3),
(12, 'Haftada 2-4 kez', 10, 3),
(13, '1', 50, 4),
(14, '2', 0, 4),
(15, '3-4', 15, 4),
(16, '5', 25, 4),
(17, '6-7', 40, 4),
(18, 'Hiç bir zaman', 40, 6),
(19, 'Ayda bir kezden az', 20, 6),
(20, 'Her ay', 10, 6),
(21, 'Her hafta', 30, 6),
(22, 'Her gün veya yaklaşık her gün', 10, 6),
(23, 'Hiç bir zaman', 50, 7),
(24, 'Ayda bir kezden az', 40, 7),
(25, 'Her ay', 0, 7),
(26, 'Hiç bir zaman', 40, 8),
(27, 'Ayda bir kezden az', 30, 8),
(28, 'Her ay', 20, 8),
(29, 'Her gün veya yaklaşık her gün', 0, 8),
(30, 'Hiç bir zaman', 40, 9),
(31, 'Ayda bir kezden az', 30, 9),
(32, 'Her ay', 20, 9),
(33, 'Her hafta', 0, 9),
(34, 'Hiç bir zaman', 40, 10),
(35, 'Ayda bir kezden az', 20, 10),
(36, 'Her ay', 0, 10),
(37, 'sa', 29, 11);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `result`
--

CREATE TABLE `result` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `e_mail` varchar(50) DEFAULT NULL,
  `point` int(11) NOT NULL,
  `form_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `result`
--

INSERT INTO `result` (`id`, `e_mail`, `point`, `form_id`) VALUES
(5, 'sa@hotmail.com', 60, 2),
(6, 'sa@hotmail.com', 60, 2),
(7, 'tarkan@hotmail.com', 190, 2),
(10, 'tarkan@hotmail.com', 0, 2),
(15, 'nefistofelesgame@hotmail.com', 210, 2),
(16, 'nefistofelesgame@hotmail.com', 210, 2),
(17, 'nefistofelesgame@hotmail.com', 210, 2),
(18, 'nefistofelesgame@hotmail.com', 210, 2),
(19, 'nefistofelesgame@hotmail.com', 210, 2),
(20, 'nefistofelesgame@hotmail.com', 210, 2),
(21, 'nefistofelesgame@hotmail.com', 210, 2),
(22, 'nefistofelesgame@gmail.com', 210, 2),
(23, 'nefistofelesgame@gmail.com', 210, 2),
(24, 'nefistofelesgame@gmail.com', 210, 2),
(25, 'nefistofelesgame@gmail.com', 40, 2),
(26, 'tarkan@hotmail.com', 30, 2),
(27, 'nefistofelesgame@gmail.com', 180, 2),
(28, 'nefistofelesgame@gmail.com', 130, 2),
(29, 'nefistofelesgame@gmail.com', 130, 2),
(30, 'nefistofelesgame@gmail.com', 130, 2),
(31, 'nefistofelesgame@gmail.com', 100, 2);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `users`
--

CREATE TABLE `users` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `nickname` varchar(40) NOT NULL,
  `password` varchar(40) NOT NULL,
  `name_surname` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `users`
--

INSERT INTO `users` (`id`, `nickname`, `password`, `name_surname`) VALUES
(1, 'nefistofeles', '123', 'Tarkan Sarıtaş');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `form`
--
ALTER TABLE `form`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `question`
--
ALTER TABLE `question`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `question_option`
--
ALTER TABLE `question_option`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `result`
--
ALTER TABLE `result`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `form`
--
ALTER TABLE `form`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Tablo için AUTO_INCREMENT değeri `question`
--
ALTER TABLE `question`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- Tablo için AUTO_INCREMENT değeri `question_option`
--
ALTER TABLE `question_option`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- Tablo için AUTO_INCREMENT değeri `result`
--
ALTER TABLE `result`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- Tablo için AUTO_INCREMENT değeri `users`
--
ALTER TABLE `users`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
