using Microsoft.IdentityModel.Tokens;

namespace ScottBrady.IdentityModel.Tokens
{
    internal class EdDsaSignatureProvider : SignatureProvider 
    {
        private readonly EdDsaSecurityKey edDsaKey;

        public EdDsaSignatureProvider(EdDsaSecurityKey key, string algorithm)
            : base(key, algorithm)
        {
            edDsaKey = key;
        }

        protected override void Dispose(bool disposing) { }
        
        public override byte[] Sign(byte[] input) => edDsaKey.EdDsa.Sign(input);
        public override bool Verify(byte[] input, byte[] signature) => edDsaKey.EdDsa.Verify(input, signature);
    }
}