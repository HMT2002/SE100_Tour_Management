<head>
Tour_Management
</head>
<body>
<div>
Có 2 việc cần làm để tạo database
1. Mở script.sql trong folder SQL, kéo chạy hết nguyên file
2. Sửa lại ConnectionString trong App.config 
      <connectionStrings><add name="QL_TOUR_DU_LICHEntities"...;data source=.\<h2>MSSQLSERVER01</h2>... /></connectionStrings>
thành
      <connectionStrings><add name="QL_TOUR_DU_LICHEntities"...;data source=.\<h2>Tên server SQL trên máy</h2>... /></connectionStrings>
</div>
</body>
