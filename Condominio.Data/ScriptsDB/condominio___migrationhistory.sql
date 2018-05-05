CREATE DATABASE  IF NOT EXISTS `condominio` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `condominio`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: condominio
-- ------------------------------------------------------
-- Server version	5.7.21-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__migrationhistory`
--

DROP TABLE IF EXISTS `__migrationhistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `__migrationhistory` (
  `MigrationId` varchar(150) CHARACTER SET utf8 NOT NULL,
  `ContextKey` varchar(300) CHARACTER SET utf8 NOT NULL,
  `Model` longblob NOT NULL,
  `ProductVersion` varchar(32) CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`MigrationId`,`ContextKey`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__migrationhistory`
--

LOCK TABLES `__migrationhistory` WRITE;
/*!40000 ALTER TABLE `__migrationhistory` DISABLE KEYS */;
INSERT INTO `__migrationhistory` VALUES ('201804292358275_v1.0.0','Condominio.Data.Migrations.Configuration','‹\0\0\0\0\0\0\ÝZ\Ýn\Û6¾°wt9 –“¶\Ø\Ø-\Òü\Åj\'ˆ“\ÞŒt\ì£H¤û\Ùz±G\Ú+Œ”õC‘’,;v\Òõ\Î&y¾sx~Hž\Ïþ÷\Û?£Ë˜xOÀft\ì\r†¾4d¦‹±Ÿ\Êù›\ßü~þit\ÅK\ïk±\î­^§$©ûR&\'A \ÂGˆ‘\Ä8\äL°¹„,PÄ‚\ã\áð÷\à\è(\0\á+,\ÏÝ¤T\â²/\ê\ë£!$2Ed\Â\" \"W3³Õ›¢D‚Bûjm\ÄbL1œ#‰|\ï”`¤Ì˜™û¢”I$•‘\'wf’3º˜%j\0‘\ÛUj\Ý¹ñ\'\Õò¾û\ë}•\àN~ð\Ëª=^(_È•6/\Û\ç\Ø?M—\ê•\Ì\\¨–þ	«Ú€\Zº\æ,.W70\Ï\Å?G¾\Ô\å[°3d´\ê•o}oš‚”3<;“Œ\Ã@#	\Ñ5’8\Õ\í\Ä\Ñnéš¦1p¶I_7\Æ\'\Â\ÂB…Y¥«\ïM\ÐòÐ…|û\ï}\ï/!*¾\ç w«\ÜV\"’§®Ž)zÂ‹l‹–¶	\ã*€„\ï\Ý\0\ÉVˆGœ¬“n\ÏÞ›aó.9‹o©„\Í\éû[\Ä •ý¬}ÍŒ¥<´ŒU²t¦PøC¦‹¡#òG\Ãa¯\Øo™pú¬™\"\â<¾kýjnq¼=\Ü-˜3Úµ‘\ãƒ\ì\ã\ìú²\Ëy\ï¡ó\"F˜¼|ÈŒbrò³o\å\×jz?µ_\ÔuW\í\ç\ÃNµ\'R\Äñyu|aL÷I\ÝZf@Q\×\å²%{:\Æ6ŸZ7°ÀBòmÏ¬¶t;‚…8‹fý®¹o¶\\\Ð\È\ëQk_e¥<’‰‚Ce\É\Øÿ\Å\Ùo7ry\ÍVÈµB­£ƒ#Gª\r\à:9Q/O\åG„©t	\Ó\'ˆl¶\Å\íY…:¥{\æ º€6û¸v\ë\Øt\r)õY\Å&W#w\ÜL\ÉH%¼¸©Ê‡¾ž¥t’JK\Í@ºv«wZ•¼Mw²¨e¼÷œ257`\ä§pDq@\Û†{[\ê7Œ±²\ã\"²#×¯Ë\Ôü\à¤A¿\Ê3À\êñ±o™ú\ÞÎ¡2=ª\æ0Xw‡E´´‘£	Ju¾\Zme>\â\Íòžò\Ílû6.^c¡h\è\æJkKM\ê\âC°fu–Gp‰¹ú¨~@ú>‹\â†e=‹¡\Ð\×Pn‹¼,„ôg»ø².{Ð‘V•;/\Õõ’l³\ÐzW:\ëòA¼\á]q\ÆH\Z\ÓöS±]ºh2M„b¬?J\Þfš ù‹1\n,78§\ãp«\ì ö\nqU£Ï‰oc¿\Ø+¶­’ŠkölªE5\é`wr&–=\×µj\èL¼j´?RÖ¡™ \Ù@ù¼\Û2ò¡þ\ÖÀ\Ä\Úð<xµ:(\ï\Û\ç”Acë”¡l*ƒV\ÉÃ”A\Þ™\0ùPŒ¼\Í11ò¡—.ÇªE±‹±šy\áDsžö’R{ùü°ž£ü\Ê\ïCi[o€õ\ßS®zÂ‘¾ÿ\'«\Ù\ß$?ªõ\Ç3‚Õ†«Dñ„¼ez¾üj\ã;ÔùŽ™j¬°‘PØ’4ª“Ó™Š\çP\Óô	ñðq›œ®0\Ý6þû\'y\ãyƒit[F‰ì…¶”\Å2£@®9„xý›\Öö\à6‰\Ûhõñö¸G\Û\ìˆwÏ£`÷\æ\ÝF†Õª™g\ä÷«™\É\ï\Zw\Ù\'[S•Í‡\ÍÖ˜\Û\â®D\äNUxZ²F®<ƒ-tH‘\ÝXÍH\Ç\îýP,\ãÿŒR´É–Þ”\â&FqýdSIý 3h¾¨‹ñj\á»\Ç&qE\×FHvñ‘M\n^Ÿ¬lˆ‚\Ã*õ\à\'›˜\Í\Ãð\î\Ã_e²ñUK/*ýÿ\na-‡\Ë5Ÿ\éœeYT,±ÿ­\0©³r‰\ç(”j:!²_˜¾\"’fÏˆ>Ó«T&©T[†ø\Ô~|\Ó%Ù¥?#[\ë6®’\ì\Ç\Ñ}lA™‰õõpE?¥˜D¥Ý—\rB„®õüöÖ±”ú_¬J¤©\ÃÊ´\å\î+¨[ˆ¢À\Ä¡\'h·m³\ëc´\à(9F%¯¾ªô‹\â\å‡ÿ\0\Å.H0³%\0\0','6.0.0-20911'),('201804300057355_v1.0.1','Condominio.Data.Migrations.Configuration','‹\0\0\0\0\0\0\ÝZ\Ûn\ã6}/\ÐôX`-\'»‹¶½‹\\‹E7\ÄÉ¾Œ4vˆR¤JRAòm}\è\'õ:”u¡¨‹e\ÇN\Ó}³I\Î\ápn\äûŸ¿þž|~Š™÷RQÁ§þ\Þh\ì{ÀCQ¾˜ú©ž¿û\Åÿü\é\Ç&§Qü\ä}+Ö½7\ëP’«©ÿ ur*|€˜¨QLC)”˜\ëQ(\â€D\"\Ø\röö@±<orrMcÈ¾\à\×cÁCHtJØ¹ˆ€©|gfªwAbP		a\ê\ã\ÚHÄ”S1:!šø\Þ!£Õ˜›û\á\\h¢QÉƒ[3-_\Ì \ì\æ9\\7\'LA®üAµ|\è9\Æû\æA%¸‘üò„x\ÆS´…~6\êe\çœú‡	‘\Z?q-ì…¸ôwx®\r\àÐ•	Hý|\ró\\üK\ä{A].pK1K\Æh€Ÿ¸~¿\ï{)c\äžAi0Ë²3-$ü$\Ñ]­Arƒ\ÙI\Z»;{]¤1H±j¿~Œ#&\ÂÝŒ\á\ê{\ç\ä\é+ð…~˜ú}\ïŒ>AT|\ÏAo9\Å\ØF-\Ó\æ\ä‘.²#:»‰” |\ï\ZX¶B=\Ðdt£|ö\Îv›w&E|-X%lO\ß\Ý¹\0ú‹\î53‘\Ê\ÐQrTÁ\ÒB9\àw>\"†\Ï\ïÇƒ|¿fÀ™ZsATHsÿ.÷\ÇQ¸¡ñúp7À`.x\ßAöwrŽã«³>\ã}\ØÅž§1¡\ìõ]f%S#>û%¯ñ²Á\'Pª}$0Q	_­Dg©•‡í”‘¢Dô•‘¢\ÔlTFnUJ$ý.o¡¯bAù‚²—ð\ÒwOmc“-U\Ä\Õð\ZTi¹nù\ë\n·C¥DH3oÖ¯­»\î\Ð)¼	±´…•Vh‘”iš0\Z¢&Sÿ§\Æyû‘\Ë»B®%j}<\Z\í56À\Ü\0i‚“0|Ä¢	åº™H”‡4!lµ.Ž\èÀ,4\î(7qgN nhµ‡\ì\îT\à¦\"\å~N¡XeªI`\ÅN³‚¡ŒF	Å¥Wöfžt#¨Œ\ÔtSo|òUÁ\Û\æøFÕ¡¬§c§\Íynƒ(\n´a™§¡Ký†±Vö\\D®ç†¥ayš\Za0,ó,°º\Ü[¦~ö–:T†G\Õg\ËF³hHƒŽŽtrN’\ë«Õ¡\æ#\Þ,oO\ß\Í\Ö\ï\ã%Fª–Æ°Ô¶\Ü	/>²\0g\ÖDygT*mJõ=1Uø8Š[–\rL†b¿–œhz°ˆ\ËB\È|v“/k\ØG=aU™óOh–d‡…v\×7¥3Â€0\"[\ÞÇ‚¥1ï®Š\Ý\ÒE¿j#c\ÃQòŽ\ÕÉ‡š“À1C£p6\î\ä€\ë\ÄA.®rô%þmm=ù¶SrG~ÍžM5¯f#\ÃÜ¦\Ð\Ærç†£V½¡WGÊš=$.Ÿ7n6B>4\Ãy\ØX+žÝ˜µþ\ÌF¬M¼™¼*\ïï—¤Uk+–¡¬J«N\ÉÝ¤U\ÞX\Ù\0ù\ÐpŒ¼m²1ò¡\×N\ïª\åq“»šy\å@k<c\Ü%\å\î\ås\Æy¶Lò\'\Ä¶\ÝyS,—øš\ê‘F\æ=qþ<û“\å¥\ß|<f\\­8\'œ\ÎA\éñ\àó\ã\èg‡³ß€?”Š\Ø&Ñ©1ÀJ‚bM>«Î›g[¼„5\çD†Dº¼y…Ù¤\Þ>ÿ¼\Ë[K«\Ù2Še+Œr„\Z\ëŒR¹’\Ò\å\Ïmëƒ»ür«\Öû\ë\ãZôq»!>¼ŒÞšu[\É_\'g†\Ð^-Tð½lC\Æ\ë\í¬;É“\Z§:Ä•kS¨\íEkm\ÌuzS‚t£l\Þ\r]Z#}^Àb6Èš\Í\ØÖ\È\Ð~\ê`W\ì\çÿŒ\êtI ÁT\ç*¦sùôÃ ¾7´_\Ò\Ç\Äup¡}Lh\Ûqu\ØE”öñ¤mü÷$j‹\Zl\×\0Þ´q\Ý\r?\Úl 0’­?õ`.)º¨ \Ì_|8„µ.\×|\ásQd”£Q±\ÄýCh‚µ•JM\ç$\Ô8‚R\Ù/_\ßK³g\Å=D_øeª“T\ã‘!¾gµMJöíŸ‘Àu\'—Iö£\í6Ž€jRs=\\ò£”²¨\Ôû¬\åB\è€0¹ž\ß\ÞÆ—\Ú\Ü\â‹\ç\é¢Áu\å\æ+K\Ô\r\Ä	C0u\Égøò\é\Ömµ\r\ë›œP²$V9F%_1ü¢ø\éÓ¿X\â’ó–&\0\0','6.0.0-20911');
/*!40000 ALTER TABLE `__migrationhistory` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-05-05 17:05:42
