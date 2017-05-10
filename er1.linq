<Query Kind="Statements" />

var results = from g in Genres
              orderby g.Name
			  select new
			  {
			   Genre =g.Name,
			   TracksCount = g.Tracks.Count90
			   };
results.Dump("Query Math 1"); 