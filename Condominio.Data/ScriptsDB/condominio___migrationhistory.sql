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
INSERT INTO `__migrationhistory` VALUES ('201804292358275_v1.0.0','Condominio.Data.Migrations.Configuration','�\0\0\0\0\0\0\�Z\�n\�6��wt9����\�\�-\��\�j\'��\��t\��H���\�z�G\�+���C��,;v\��\�&y�sx~H�\���\�?��˘xO�ft\�\r��4d����\���\���~�it\�K\�k�\�^�$���R&\'A \�G��\�8\�L���,PĂ\�\���\�\�(\0\�+,\�ݤT\��/\�\��!$2Ed\�\" \"W3�՛�D�B�jm\�bL1�#�|\�`�̘����I$��\'wf�3��%j\0�\�Uj\���\'\���\�}�\�N~�\��=^(_ȕ6/\�\�\�?M�\��\�\\���	�ڀ\Z�\�,.W70\�\�?G�\�\�[�3d�\��o�}o���3<;��\�@�#	\�5�8\��\�\�\�n隦1p�I_7\�\'\�\�B�Y��\�M\��Ѕ|�\�}\�/!*�\�w�\�V\"����)zl���	\�*��\�\�\0\�V�G���n�\�ޛa�.9�o��\�\��[\� ���}͌�<��U�t�P�C���#�G\�a�\�o�p���\"\�<�k�jnq�=\�-�3ڵ�\�\�\�\���\�y\���\"F��|Ȍbr�o\�\�jz?�_\�uW\�\�\�N�\'R\��yu|aL��I\�Zf@Q\�\�%{:\�6�Z7��B�mϬ�t;��8�f���o�\\\�\�\�Qk_e�<���Ce\�\��\�\�o7ry\�VȵB���#G��\r\�:9Q/O\�G��t	\�\'�l�\�\�Y�:�{\����6���v\�\�t\r)�Y\�&W�#w\�L\�H%���ʇ����t�JK\�@�v�wZ��M�w��e���257`\�pDq@\��{[\�7���\�\"�#ׯˍ\��\�A�\�3�\��o��\�Ρ2=�\�0Xw�E����	Ju�\Zme>\�\���\�l�6.^c�h\�\�JkKM\�\�C�fu�Gp�����~@�>�\�e=��\�\�Pn��,��g���.{БV�;/\���l�\�zW:\��A�\�]q\�H\Z\��S�]�h2M�b�?J\�f� ���1\n,78�\�p�\� �\nqU�ωoc�\�+����k�l�E5\�`wr&�=\��j\�L�j�?R֡� \�@��\�2��\��\�\��<x�:(\�\�\�Ac딡l*�V\�ÔA\��\0�P��\�11�.ǪE����y\�Ds���R{������\�\�Ci[o��\�S�z��\'�\�\�$?��\�3�Ն�D���e�z��j\�;�ԁ���j���Pؒ4��ә�\�P\��	��q���0\�6��\'y\�y�it[F�셶��\�2�@�9�x��\��\�6�\�h����G\�\�wϣ`�\�\�F�ժ�g\����\�\�\Zw\�\'[S�͇\�֘\�\�D\�NUxZ�F�<�-tH�\�X͝H\�\��P,\���R�ɖޔ\�&Fq�dSI��3h�����j\��\�&qE\�FHv�M\n^��l��\�*�\�\'��\�\��\�\�_e��UK/*��\na-�\�5�\�eYT,���\0���r�\�(�j:!�_��\"�fρ�>ӫT&�T[���\�~|\�%٥?#[\�6���\�\�\�}lA����pE?��D�ݗ\rB�����ֱ��_�J��\�ʴ\�\�+��[���\���\'h�m�\��c�\�(9F%����\�\��\0\�.H0�%\0\0','6.0.0-20911'),('201804300057355_v1.0.1','Condominio.Data.Migrations.Configuration','�\0\0\0\0\0\0\�Z\�n\�6}/\��X`-\'������\\�E7\�ɾ�4v�R�JRA�m}\�\'�:�u���e\�N\�}�I\�\�pn\������|~���RQ���\�h\�{�CQ�������\���\�\�&�Q�\�}+ֽ7\�P�����ur*|���QLC)��\�Q(\�D\"\��\r��@�<or�rMcȾ\�\�c�CHtJع���|gf�wAbP		a\�\�\�HĔS1:!��\�!�՘��\�\\h�QɃ[3-_\� \�\�9\\7\'LA��A�|\�9\��\�A%����x\�S��~6\�e\���	�\Z?q-셸�wx�\r\�Е	H�|\r�\\�K\�{A].pK1K\�h���~�\�{)c\�Ai0˲3-$�$\�]�Ar�\�I\Z�;{]�1H�j�~�#&\�݌\�\�{\�\�\�+��~��}\�>AT|\�Ao9\�\�F-\�\�\�.�#:�����|\�\ZX�B=\�dt�|�\�v�w&E|-X%lO\�\��\0���\�53�\�\�QrT�\�B9\�w>\"�\�\�ǃ|�f��ZsATHs�.�\�Q����p7�`.x\�A�wr�㫳>\�}\�Ş�1�\��]f%S#>�%���\'�P�}$0Q	_�Dg���픑�D����\�lTFnUJ$�.o��bA�����\�wOmc�-U\�\��\ZTi�n�\�\n�C�DH3o֯��\�\�)��	����Vh��i�0\Z�&S��\�y��\��B�%j}<\Z\�56�\�\0i��0|Ģ	庙H��4!l�.�\��,4\�(7qgN nh���\�\�T\�\"\�~N�Xe�I`\�N����F	�ťW�f�t#��\�tSo|�U�\�\��Fա��c�\�yn�(\n�a���K���V�\\D�熥ay��\Za0,�,��\�[�~��:T�G\�g\�F�hH���trN�\�ա\�#\�,oO\�\�\�\�\�%F��ưԶ\�	/>�\0g\�DygT*mJ�=1U�8�[�\rL�b���hz��\�B\�|v�/k\�G=aU��Oh�d��v\�7�30\"[\�ǂ�1ﮊ\�\�E�j#c\�Q�\�ɇ���1C�p6\�\�\�\�A.�r�%�mm=��SrG~͞M5�f#\�ܦ\�\�r熣V���W�Gʚ=$.�7n6B>4\�y\�X+�ݘ��\�F�M���*\�Uk+���J�N\�ݤU\�X\�\0�\�p��m�1�\�N\�\�q���y\�@k<c\�%\�\�\�s\�y�L�\'\��\�yS,���\�F\�=q�<��\�\�|<f\\�8\'�\�A\��\��\�\�g��߀?��\�&ѩ1�J�bM>�Λg[��5\�D�D��y�٤\�>��\�[K�\�2�e+�r�\Z\�R��\�\�\�m냻�r�\��\�\�Z�q�!>��ޚu[\�_\'g�\�^-T�lC\�\�\��;ɓ\Z�:ĕkS�\�Ekm\�uzS�t�l\�\r]Z#}^�b6Ț\�\�֍\�\�~\�`W\�\���\�tI��T\�*�s��à�7�_\�\�\�up�}Lh\�qu\�E���m��$j�\Zl\�\0޴�q\�\r?\�l 0��?�`.)�� \�_|8��.\�|\�sQd��Q�\��Ch���JM\�$\�8�R\�/_\�K�g\�=D_�e��T\�!�g�MJ�ퟑ�u�\'�I��\�6��jRs=\\򣔲�\���\�B\�0��\�\�Ɨ\�\�\�\�\��u\�\�+K\�\r\�	C0u\�g��\�\�m�\r\���P��$V9F%�_1���\�ӿX\��&\0\0','6.0.0-20911');
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
