<Query Kind="Statements" />

var results = from g in Genres
              where  g.Name.Equals("Heavy Metal")
			  select new
			  {
			   tracksCount = g.Tracks.Count(),
			   Tracks = from t in g.Tracks
			            select new
				{
				   TrackName = t.Name
				   AlbumName = t.Album.Title,
				   Milliseconds = t.Milliseconds,
				   Size = (t,Bytes / 1000) + "kb',
				   Price = t.UnitPrice
				 }
			   };
results.Dump("Query Math 2");