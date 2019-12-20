-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 21 Nov 2019 pada 07.01
-- Versi server: 10.3.16-MariaDB
-- Versi PHP: 7.3.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_karyawan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_absensi`
--

CREATE TABLE `t_absensi` (
  `id_absensi` int(11) NOT NULL,
  `nik` varchar(20) NOT NULL,
  `jam_masuk` time NOT NULL,
  `jam_kerja` time NOT NULL,
  `tgl_kerja` date NOT NULL,
  `jam_pulang` time NOT NULL,
  `telat_masuk` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_gaji`
--

CREATE TABLE `t_gaji` (
  `id_gaji` int(11) NOT NULL,
  `no_slip` varchar(15) NOT NULL,
  `nik` varchar(20) NOT NULL,
  `tgl_gaji` date NOT NULL,
  `id_jabatan` int(2) NOT NULL,
  `nama_jabatan` varchar(5) NOT NULL,
  `gaji_pokok` decimal(8,0) NOT NULL,
  `tunjangan` decimal(8,0) NOT NULL,
  `uang_lembur` decimal(8,0) NOT NULL,
  `pot_npjs_kes` decimal(8,0) NOT NULL,
  `pot_bpjs_ket` decimal(8,0) NOT NULL,
  `pot_lain2` decimal(8,0) NOT NULL,
  `no_rekening` varchar(20) NOT NULL,
  `nama_rekening` varchar(45) NOT NULL,
  `nama_bank` varchar(20) NOT NULL,
  `total_gaji` decimal(8,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_jabatan`
--

CREATE TABLE `t_jabatan` (
  `id_jabatan` int(2) NOT NULL,
  `nama_jabatan` varchar(15) NOT NULL,
  `gaji_pokok` decimal(8,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `t_jabatan`
--

INSERT INTO `t_jabatan` (`id_jabatan`, `nama_jabatan`, `gaji_pokok`) VALUES
(1, 'marketing', '20000'),
(2, 'staf', '10000'),
(3, 'manager', '200000'),
(4, 'karyawan', '30000'),
(5, 'karyawati', '40000'),
(0, 'marketing', '20000');

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_karyawan`
--

CREATE TABLE `t_karyawan` (
  `nik` varchar(15) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `tempat_lahir` varchar(20) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `agama` varchar(15) NOT NULL,
  `status` varchar(10) NOT NULL,
  `kewarganegaraan` varchar(3) NOT NULL,
  `no_hp` varchar(13) NOT NULL,
  `email` varchar(25) NOT NULL,
  `alamat` varchar(35) NOT NULL,
  `pendidikan_terakhir` varchar(4) NOT NULL,
  `pt_terakhir` varchar(50) NOT NULL,
  `jabatan` varchar(15) NOT NULL,
  `tgl_masuk` date NOT NULL,
  `bagian` varchar(20) NOT NULL,
  `gaji` varchar(10) NOT NULL,
  `status_karyawan` varchar(15) NOT NULL,
  `status_kerja` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `t_karyawan`
--

INSERT INTO `t_karyawan` (`nik`, `nama`, `tempat_lahir`, `tgl_lahir`, `agama`, `status`, `kewarganegaraan`, `no_hp`, `email`, `alamat`, `pendidikan_terakhir`, `pt_terakhir`, `jabatan`, `tgl_masuk`, `bagian`, `gaji`, `status_karyawan`, `status_kerja`) VALUES
('001', 'bowo', 'kapuas', '0000-00-00', 'islam', 'belum nika', 'WNI', '082158451232', 'andre@gmail.com', 'jl.vetran', 'sma', 's1', 's3', '0000-00-00', 'marketing', '120', 'tetap', 'aktif'),
('08', 'bowo', 'kapuas', '2019-10-22', 'Islam', 'menikah', 'WNI', '0821546474', 'andre@gmail.com', 'jln vetran', 'SMA', 's1', 'manager', '2019-10-15', 'marketing', '300000', 'Tetap', 'Aktif'),
('123', 'buy', 'kuy', '2019-10-22', 'kristen', 'menikah', 'WNA', '1436376475', 'andre@gmai', 'jln1', 'D2', 'lp3i', 'guy', '2019-10-22', 'yre', '500', 'Tetap', 'Aktif'),
('1808410012', 'Novandri cahyadi', 'kapuas', '0000-00-00', 'islam', 'belum kawi', 'WNI', '082154301926', 'andre@gmail.com', 'jll.vetran', 's1', 'lp3i pky', 'maneger', '0000-00-00', 'staf', '50000', 'tetap', 'aktif');

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_lembur`
--

CREATE TABLE `t_lembur` (
  `id_lembur` int(10) NOT NULL,
  `nik` varchar(20) NOT NULL,
  `nama_karyawan` varchar(45) NOT NULL,
  `id_jabatan` int(2) NOT NULL,
  `tgl_lembur` date NOT NULL,
  `jum_jam_lembur` int(2) NOT NULL,
  `uang_lembur` decimal(8,0) NOT NULL,
  `total_uang_lembur` decimal(8,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `t_gaji`
--
ALTER TABLE `t_gaji`
  ADD PRIMARY KEY (`id_gaji`);

--
-- Indeks untuk tabel `t_karyawan`
--
ALTER TABLE `t_karyawan`
  ADD PRIMARY KEY (`nik`);

--
-- Indeks untuk tabel `t_lembur`
--
ALTER TABLE `t_lembur`
  ADD PRIMARY KEY (`id_lembur`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `t_gaji`
--
ALTER TABLE `t_gaji`
  MODIFY `id_gaji` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `t_lembur`
--
ALTER TABLE `t_lembur`
  MODIFY `id_lembur` int(10) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
