<Query Kind="Statements">
  <Connection>
    <ID>9437b2ae-15d9-4345-9ea7-c11761f4c9b1</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
              where  g.Name.Equals("Heavy Metal")
			  select new
			  {
			   tracksCount = g.Tracks.Count(),
			   Tracks = from t in g.Tracks
			            select new
				{
				   TrackName = t.Name,
				   AlbumName = t.Album.Title,
				   Milliseconds = t.Milliseconds,
				   Size = (t.Bytes / 1000) + "kb",
				   Price = t.UnitPrice
				 }
			   };
results.Dump("Query Math 2");