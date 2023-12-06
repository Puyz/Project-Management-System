using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors
{
    public class MethodInterception : MethodInterceptionBaseAttribute
    {
        //işlemden önce çalışır
        protected virtual void OnBefore(IInvocation invocation) { }
        //işlmeden sonra çalışır
        protected virtual void OnAfter(IInvocation invocation) { }
        //işlem başarısız ise çalışır
        protected virtual void OnException(IInvocation invocation, Exception e) { }
        //işlem başarılıysa çalışır
        protected virtual void OnSuccess(IInvocation invocation) { }

        public override void Intercept(IInvocation invocation)
        {
            var isSucces = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();//işlem başarılıysa devam etsin
            }
            catch (Exception e)//işlem hata verirse
            {
                isSucces = false;
                OnException(invocation, e);//işlem başarısız ise hata yazdır
                throw;
            }
            finally
            {
                if (isSucces)//işlem başarılıysa
                {
                    OnSuccess(invocation);//devam etsin
                }
            }
            OnAfter(invocation);//tüm işlemlerden sonra tekrar döndür
        }
    }
}
