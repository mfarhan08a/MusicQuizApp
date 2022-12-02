using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicQuizApp
{
    internal class SearchResult
    {
        public int resultCount { get; set; }
        public Result[] results { get; set; }

        public class Result
        {
            public string wrapperType { get; set; }
            public string kind { get; set; }
            public int artistId { get; set; }
            public int collectionId { get; set; }
            public int trackId { get; set; }
            public string artistName { get; set; }
            public string collectionName { get; set; }
            public string trackName { get; set; }
            public string collectionCensoredName { get; set; }
            public string trackCensoredName { get; set; }
            public string artistViewUrl { get; set; }
            public string collectionViewUrl { get; set; }
            public string trackViewUrl { get; set; }
            public string previewUrl { get; set; }
            public string artworkUrl30 { get; set; }
            public string artworkUrl60 { get; set; }
            public string artworkUrl100 { get; set; }
            public float collectionPrice { get; set; }
            public float trackPrice { get; set; }
            public DateTime releaseDate { get; set; }
            public string collectionExplicitness { get; set; }
            public string trackExplicitness { get; set; }
            public int discCount { get; set; }
            public int discNumber { get; set; }
            public int trackCount { get; set; }
            public int trackNumber { get; set; }
            public int trackTimeMillis { get; set; }
            public string country { get; set; }
            public string currency { get; set; }
            public string primaryGenreName { get; set; }
            public bool isStreamable { get; set; }
            public string contentAdvisoryRating { get; set; }
            public string copyright { get; set; }
            public string description { get; set; }
            public int collectionArtistId { get; set; }
            public string collectionArtistViewUrl { get; set; }
            public float trackRentalPrice { get; set; }
            public float collectionHdPrice { get; set; }
            public float trackHdPrice { get; set; }
            public float trackHdRentalPrice { get; set; }
            public string longDescription { get; set; }
            public bool hasITunesExtras { get; set; }
        }

        /*public class ResultDistinct : IEqualityComparer<Result>
        {
            public bool Equals(Result x, Result y)
            {
                return x.trackId == y.trackId;
            }

            public int GetHashCode(Result obj)
            {
                return obj.wrapperType.GetHashCode() ^
                    obj.kind.GetHashCode() ^
                    obj.artistId.GetHashCode() ^
                    obj.collectionId.GetHashCode() ^
                    obj.trackId.GetHashCode() ^
                    obj.artistName.GetHashCode() ^
                    obj.collectionName.GetHashCode() ^
                    obj.trackName.GetHashCode() ^
                    obj.collectionCensoredName.GetHashCode() ^
                    obj.trackCensoredName.GetHashCode() ^
                    obj.artistViewUrl.GetHashCode() ^
                    obj.collectionViewUrl.GetHashCode() ^
                    obj.trackViewUrl.GetHashCode() ^
                    obj.previewUrl.GetHashCode() ^
                    obj.artworkUrl30.GetHashCode() ^
                    obj.artworkUrl60.GetHashCode() ^
                    obj.artworkUrl100.GetHashCode() ^
                    obj.collectionPrice.GetHashCode() ^
                    obj.trackPrice.GetHashCode() ^
                    obj.releaseDate.GetHashCode() ^
                    obj.collectionExplicitness.GetHashCode() ^
                    obj.trackExplicitness.GetHashCode() ^
                    obj.discCount.GetHashCode() ^
                    obj.discNumber.GetHashCode() ^
                    obj.trackCount.GetHashCode() ^
                    obj.trackNumber.GetHashCode() ^
                    obj.trackTimeMillis.GetHashCode() ^
                    obj.country.GetHashCode() ^
                    obj.currency.GetHashCode() ^
                    obj.primaryGenreName.GetHashCode() ^
                    obj.isStreamable.GetHashCode() ^
                    obj.contentAdvisoryRating.GetHashCode() ^
                    obj.copyright.GetHashCode() ^
                    obj.description.GetHashCode() ^
                    obj.collectionArtistId.GetHashCode() ^
                    obj.collectionArtistViewUrl.GetHashCode() ^
                    obj.trackRentalPrice.GetHashCode() ^
                    obj.collectionHdPrice.GetHashCode() ^
                    obj.trackHdPrice.GetHashCode() ^
                    obj.trackHdRentalPrice.GetHashCode() ^
                    obj.longDescription.GetHashCode() ^
                    obj.hasITunesExtras.GetHashCode();
            }
        }*/



    }
}
