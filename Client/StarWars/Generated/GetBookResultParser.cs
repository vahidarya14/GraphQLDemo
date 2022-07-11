using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using StrawberryShake;
using StrawberryShake.Http;

namespace Client
{
    public class GetBookResultParser
        : JsonResultParserBase<IGetBook>
    {
        private readonly IValueSerializer _stringSerializer;

        public GetBookResultParser(IEnumerable<IValueSerializer> serializers)
        {
            IReadOnlyDictionary<string, IValueSerializer> map = serializers.ToDictionary();

            if (!map.TryGetValue("String", out IValueSerializer serializer))
            {
                throw new ArgumentException(
                    "There is no serializer specified for `String`.",
                    nameof(serializers));
            }
            _stringSerializer = serializer;
        }

        protected override IGetBook ParserData(JsonElement data)
        {
            return new GetBook
            (
                ParseGetBookBook(data, "book")
            );

        }

        private IBook ParseGetBookBook(
            JsonElement parent,
            string field)
        {
            JsonElement obj = parent.GetProperty(field);

            return new Book
            (
                DeserializeString(obj, "title")
            );
        }

        private string DeserializeString(JsonElement obj, string fieldName)
        {
            JsonElement value = obj.GetProperty(fieldName);
            return (string)_stringSerializer.Deserialize(value.GetString());
        }
    }
}
