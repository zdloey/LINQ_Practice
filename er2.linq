<Query Kind="Statements">
  <Connection>
    <ID>9437b2ae-15d9-4345-9ea7-c11761f4c9b1</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from m in MediaTypes
              select new 
			  {
			    Name = m.Name,
				Tracks = from t in m.Tracks
				            select new
				{
				  TrackName = t.Name,
				  Album = t.Album.Title,
				  Artist = t.Album.Artist.Name,
				  ReleaseYear = t.Album.ReleaseYear,
				  ReleaseLabel = t.Album.ReleaseLabel,
				  Genre = t.Genre.Name
				  }
			};
results.Dump();