﻿using NBitcoin;

namespace Stratis.Bitcoin.Networks
{
    public static class Networks
    {
        public static NetworksSelector Bitcoin
        {
            get
            {
                return new NetworksSelector(() => new BitcoinMain(), () => new BitcoinTest(), () => new BitcoinRegTest());
            }
        }

        public static NetworksSelector Stratis
        {
            get
            {
                return new NetworksSelector(() => new StratisMain(), () => new StratisTest(), () => new StratisRegTest());
            }
        }

        public static NetworksSelector Strax
        {
            get
            {
                return new NetworksSelector(() => new StraxMain(), () => new StraxTest(), () => new StraxRegTest());
            }
        }
        
        public static NetworksSelector Amaza
        {
            get
            {
                return new NetworksSelector(() => new AmazaMain(), () => new AmazaTest(), () => new AmazaRegTest());
            }
        }
    }
}
