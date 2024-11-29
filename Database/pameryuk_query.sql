-- Select Query for kisahhidup of a user
select *
from kisahhidup kh
	inner join organisasi o ON o.ID = kh.Organisasi_id
    inner join Kota K on o.Kota_Id = k.id
where kh.username ='';

select * from kisahhidup kh	inner join organisasi o ON o.ID = kh.Organisasi_id inner join Kota K on o.Kota_Id = k.id where kh.username ='';

-- Query for user log in
select *
from user u
	inner join kota k on u.kota_id = k.id
where username ='' and password ='';

select * from user u inner join kota k on u.kota_id = k.id where username ='' and password ='';

-- Query for user daftar
INSERT INTO `pameryuk`.`user` (`username`, `password`, `tglLahir`, `noKTP`) VALUES ('', '', '', '');