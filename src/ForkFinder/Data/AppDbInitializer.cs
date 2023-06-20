using ForkFinder.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace ForkFinder.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Restaurantes
                if (!context.Restaurantes.Any())
                {
                    context.Restaurantes.AddRange(new List<Restaurante>()
                    {
                        new Restaurante()
                        {
                            Nome = "Churros Gourmet",
                            Email = "Teste",
                            Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                            CNPJ = "58.337.334/0001-35",
                            FotoPerfil = "https://lh3.googleusercontent.com/fife/APg5EObC0Ri8b_PP0yWeS6PKKrMRK7YB5B_1lZQLihiQGd8Sk0XMQlDE-fk5zQ93XndCyW3JFCN-kR13zGxJtkwUgRIoceZCqFnmsq7IPqVSeWGcuAe6ToHJqk-Ea_XL-0Sf18EKWM1MSROGgUzK584kawg0lOZPoK_9jgH9qPU0YqWVGnYwbKTgIsoeXMamK-N7tjCfiksZqd0cLG3_nCvbPCR-wyTjvbgT3md-iEo70jhjI2DNH_YOhqXtl5R97D-G2ws_TujlCaASAeD1TTGb2NSUjSLt9ZnBH4AuvmcOyzydkib67_cV-lXXLtGSTgPCPgArP053d11MX4d5_LtxwQqEDMO20JDukfp6BnBx4Qf16zj4q8hnlgONvFq_of_Hoy-4Mpj0YmA6sjUG8pc0ePXZvEPTzZDJUAXI_ex_wyuU3NUfv7OYuqfh6j3nAUHjLdt0n5INLQRFOZBSPl85vZN3_3zkzT3JTkDr-p3lXgywu1lfPyNimd31Bo-9L2w6j-8t57le--6Eg6IyYSsL13UWTR1yjbq9YzeipnwgzP-QZx-IKvCseogGUTHEPvyrCRr0EyQHd0yXE2CPIeWRxEDMz0IQ62POzh1wqKJ_WJBSigAkvWXUbb0AFH5RpdCX7M3aSOynGDzHnxbOnpD5nfltfmh9AppmaplrLT7FtPecmeSi9RjvdPGAx8PcpyWB7LpV_AWwvRFBzxFnsn2BbIcCbTHFuGLw3wawFxaxtQb_MgvPQrQ-uJouAcUhYtx30_VQkvUlLBVVhaRjN7NXyZFJS_7T3e7BTF-duWRO9PCUw3XZ-XWjW6B3EGDIbO83h-9ARbATv1ClvLcGHqIjZffgTlrPq7n3eu4CM_RC05pLP5ZvkAbypO0UpD-DAqfaLmrJY7J4QMtyNxTGMnlOdy-Odq4YxdkfbGSxT3bvctamzYm-JnEvootkwWWw-TGykWJjm0NTUSwxr_p-uxko7Y8zsSWHEtl89tWtKGRGAk6aEe-r9mDF-S225oW7OlGmH85ZLJdb3Ayp6oYIP0xq3esHgKZXtI8UEWFfeKGbC_geY3g2LCelOPX4Kdo-aG8EvNybuTONTwFTK6L2Z1KKsFKmdN4fCSmgyZwadjoM5QI_IWz2YQTGYVvGk4zyKHQWicSC0Mp69nPO7oRRxQIDsQvkzDApJR6ODDpAF_yaXMsSAmmfN09PG3-wR06Ifou8aAdy4CH28hmOk00QtltdS1w9k1UrYPKXXdWWoh4iQm6Ic-le3WiaX68EoWeWs7a_1OvX4a16zd6fAy-UqIXFPJg3FkBYlpUsw38R4EPKqE3vuYbvwdFBfWUwJ6YO2OCCZFYV_0RzgfT1FawKxY_8Pfvj9tw1fksYvinDJQofCEA6BTllV6PFK8dlECQIRUrbDkvQDpvS6z1HFO8scuZckOYp5Smhdw0gl-DHBsFq5Dwh6XA3w08tDcO4sSzRN1WfHjVkM9A9TjnPNIWnLoUPVIbE_U9Bv_1ZJop_s67nR9-35QVV3Y3wzc_5XKx5DAYwKmCMUQ=w1920-h860",
                            DescricaoRestaurante = "Isto é uma descrição do restaurante Churros Gourmet"
                        },
                        new Restaurante()
                        {
                            Nome = "Romeu & Juliet Bistrô",
                            Email = "Teste",
                            Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                            CNPJ = "89.743.180/0001-05",
                            FotoPerfil = "https://lh3.googleusercontent.com/fife/APg5EOYXm2jOkw5SRKo1IkvnoJ0ri0M4liZ9vFd9N79bnrKeKEQwLI1BtXPo5eFQEfPVKXJ90soqjii63fY1m3F0viTBQiUn7-0qZSKnqtIY_D5r2HhNx9b0bUAiaU2xGQHvCupvB5wmBWLRWDgxb2sWX5yJw6Pq8pLxXZoMdGfAlPMxjeL08v2vwFTc8YrrRjsIw48KodAx4L1k7ZhVgUFijW_-iDctKpO5mp5YOp6vL12oJ7vT33LIn0ti0I3uMhB6V9V7xj_oFc6SZl6jVfe6thrpQW3lXBDr_0wxN7yFRyRBdpO0qsUyenOWBee80FXcDcTC7uvACxtOcagIKimPY8Bt0NnSXs2x95wC3f82vXsgHFZ9l3u0YVaTyK-kItUZSoCAF6nZTtGvJ1CT4VMLwJW31ZiiQHUX8yIHkiCBUuwAkfiuAj-zSUhhm8PTEqPyLe4DKJPWpD3Q5l1WFXzaiRQP59pOaD22Ac5BkZY-Y6VlIv6TyPKn2RgS7EipJ2B8GDoa4usWwgmnfxfzSQK0Em6v3TMoXu6cp3b7QSrqKgQjWjzuldly_WzWFN9-6qSgVCAIvkslerS-fJ2UTUGiIW8Qwws4N8GF1eOk8BrEqcfWd1njEd7zDHHUwZXxWfu46fQy2SyyO-B5krOndqYw962qBZP9FZrKl82UT3_I85EFx-gWOwp1djn9jKX4_eWWQ2nRnyRMDL7nD44BwEZtnkzBmhTbSm4sNbXicA61prvKObYHP65h6QuAfDQ4NeztHn7V8NH6tnuPUoknbTnOMkZq6VnB3ezYMFxZqRBaYKr_l944w6HWKJqVWvCM6blkh8wAADpAwUiIqAphUH_6uJgpkzISJXdjdiKidlc8fNCpXrHJKZLoKuPczr0D7pDgX1Jt4ULVTCpoNBeImRNH_MpoeWOWB0NuhRGHNvpJJdMztbIiwct8AuM3NQOLXydQWG1XMGGU-l66IvZk0j-LwF2jDipTPV8AjtTgGRwDD3hRqLxBynMNZy14KY9Gh7sIMHa_a5kt1YyM4--QqYp5BokevM8Bii6nMUyUqimpC8dgIMXMqW3fZd9tYyVl4lEIRV4IgWXZ8V9duID2Ck3CwNV2YKZOlZg0rTfX7RWs86_07fKl2Su3PNYkkqsuiwK1BGUTaI7tLlu69XOxlOHtPfk4wJK4X6lPqQWNCLMV0gTRkiBjJlRcjbXgkVpAB1Xy54s7vwl5xyY4N7mbQr-oFFFqaO_x_4zjhI2gLGrrbzEJ58-BBFjo-qtvhuGfvCHa-bIko0dA4oN5QEpq5hrXpDVHSEEkOHxZfgd_WCqc2HTKfPPNk01cYzPpLD1YPASs9diCJaQN4tMAhxLi0NKeBNWQC9j-7_TWTHT9Wrglx4FdXNIFXyBR2-oEpEFM-9ZaMCx3ixGDjfNZxB8K91aCrO3GQYrvDDeavo1fzpUC1_gY6XROM1C7P89ueFVt8MsuSjrP1UWa2qAL-ykUK91HjBfC_FpyY9NH45s0hgFlpSwQInbbSZoq8TkxC1kHkH7eX8u2OQ=w1227-h860",
                            DescricaoRestaurante = "Isto é uma descrição do restaurante Romeu & Juliet Bistrô"
                        },
                            new Restaurante()
                        {
                            Nome = "Gosto Verde",
                            Email = "Teste",
                            Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                            CNPJ = "95.943.397/0001-61",
                            FotoPerfil = "https://lh3.googleusercontent.com/fife/APg5EOYpC1BlzeKvJrct39s-RfPhX5yY9WsKSLIeKMJIVlrosAVY92hEYR-lhZ925Vx-_k2hPXUU5Fxv7js9bXp06b_QGoZ8SjUDGyC6oB25NBmeBXitPbXHB7fG9DiVD19PdNvoj-D4rQtmG05Q5UwqjVxnrp_O7K4Q6FfZlcXkAlrhn7Jugwq6uFsD_BFJ7oElIRB4VcLM3BiIYj5sLxmbbYhH9NpVPt_La9uPmJZjbCX-vKIYKkwktV6yO75t9WVGbJtFQUqgTShdAFVouCMfpm56XJrdnf2hHImurEF0LFE75fhJQ2YVkC2S1ROZTIjKQrocRLPi2xpaBcJbk7se35qiaMgsppdJTi-xjgzCl3ofOCMTiOHii8CaimuADX0f9Bm2TsDle0wb8DEz2tFWGdBiUym0E1gUCfigiDs47eJpY7aLCMX4kGTuWQODOFRAvJFWEAErbpwh4x4OlufFoY6Gtkz3RE97QpWIXzHUVKvzUEwPzTrAeSSZgtqCsbSddfwwCwr-au6mNjZpYzJwLd_jcFV5vD_WEhYR5ML6CmqPjjvyg5M-WPKcf9GK5x4r_QYO2j7NRknI2kUkUF8maG6I7Lzi5sEStJbCWkezjP2TOFYQNd2q47-IyzkmHAzFLSBT0pETNUY52Ig-WEBClM4BZBv2wZk2jdkvDQd33CpjabC7HvdHYyzPeZIf65qGrsz9LOZ9TOZ-45Gj8CkBgW-0GGXhxhkKlEs9fdReeEwAWNlChIMF7JA3x0PPMG4Az8ahkjpDSqGRD8sxvE3M4kTW4iqRx8chr7Fux4V0q60lJ84xQYz6gsFHni-3tbK7KGQgTNfUzh0-xtEdm3YD-HJOLgYzMkTixkVNzl_SKm1xpFMxu_ThN5P-RNrqCNFHcH0npkyoEKkPX68k5iEr1HfxI0cV-n9dN_K1mD4MrfPoPmFfpiifdzDOK7AKpyjJZ2dTrtXbmXU10ZaoipIB1vt_rfNiQbO2mC6alr7jpzrg-90OG_0hTmKogKK-ACjvZYyAXbp8XqCICmhzPrvOi1zUsnmle7_4HU9cI8LWUMVt4OUd_B2-sShBj3PiB53a4EBCX4uPmyyFDgIaeQYvUd69RgiIRyhyy9mUTlT6hwGSGPwcTvpb5zThfEeWgSevdtT3wll6AUq0qZGVw_nAKGnLkk1wHi4CvyiSg0CCKzj-xBnhuTSWNSwWDX78sYZKfL42VqcuGmEvuS-6qPV9aGxHirSAWWwujak3ZoBWt0TNKthLHBA0QDSb0mYLfKWdRsIVd9s5gDGJDMuvYAIzAwUiUHdoOV1zR5mm3P0R-EsVji0qdeVBqybv0QwdCtoxIXj27lFpTOBmy2joXEfkicnR4hrsh12TMwyjjTAjXJd4k9BicIMkvNlKB-KdLLrf86MX8kOiwdghLYrGgsSH3zKr_IrKrBieQ_TXKQq_lDgh3JPRn-qI1DWbCZD9d3VZXYptDYjawpdLQNtOZwRl11n90ywjtcn5khYjk0B0zJSbyPj42fCI67OMi4EqO8aNfhiTkw=w1227-h860",
                            DescricaoRestaurante = "Isto é uma descrição do restaurante Gosto Verde"
                        },
                            new Restaurante()
                        {
                            Nome = "Porco na Brasa",
                            Email = "Teste",
                            Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                            CNPJ = "62.771.119/0001-15",
                            FotoPerfil = "https://lh3.googleusercontent.com/fife/APg5EOYpsYilj8G6rsj7vIMKjeqYA9F05Vwz7mckhY1-YqD8IeYP4CiX_vj-kpqe3eP0f6OM2xfj5sum9jSMFCdrssLg93za_CWfCB2ziTy6f5qGZyZGtZrE-gc8yBGNt6777FcaU8hpAwmP-jfOXMEqRSntyYWcpb6--ZZpEztOvYrlFzHIQqBKsSn0c7APTHSLTmCiQtfVzT5TbsHEYKPMkNHC4bNHVCr9uF4aeozi810KWvZY_7X7WbFajO796w-VBFdMyzZVeNKlJxQiW_s8_xBe3haTUwwWUoheepEsvXZDMAAgEonbNNKe_M95mDq391vpMlgIHAMCoFNNavFk0_qg0ibq11CLzamXv3gxoVme4Hj7Nhh9pbsex5JZzcATaqvfomMygHtz5dOmKY-R9lI2cM-bZKX18yDg2JF8OD6viF48-DHb_UaqkA9IfFDLyGlJWgqSsgSb56YX6_ZaiXH3-EMOy9qIRgmt4r_CkDfjR9QgxyluouLN7nkyCJS90dzkJvgTt-oHxsrCZDO3hzdJOGRpAt1OE5TGwBWBknGUuy83q0pt2xLx7c9WkfqttTqTKPg8oJnAkpG6coomsTMLMCILng-4Wy6BsRE1j8VWAD43wEZ9hWLGfYiwqOflAqzxyqLsAx_L9o74XSU4p5RUBzIyghYoRJDN2TowGOpA4BwJEscbudYWX6yYRonMSKZfTPwhVb0VlYGsIoTAXqDc9W_yT7UpGTHPPvh2mdQaRMcFtMpz-Alf1KBLNsTa9admyYWS8hBHtaMPQ2yZ5p7cekkGGx4DhDTPvteLIoSst07etcqJphBZCzoqQSDqY22ghcMcW0KrzFgQeh2ItFdrAQx1uFXfzim-4Kd_Smv0iJnMLxdiAEcm0RXYqJNmQLBKKnjPwGDDLij2BvYSsrzPY7rd9aNNc-9RtJNaGK-q9jzZmL7Iv5cHI8Im6W15u4HzM0gEYfsnik9qyKM3ojNOluywrExn9Qf0CbphTx2c4hXWkbsZkG5LYOhNxCa90CUNzujtNJuQby70VYqbX2e5DLPut5muO9y-ow2ajpaX50D1tLEcN9MlDsh2oItVcij815dvaUf3rN5P-d3D_8xwOXE_HWuWpLPW_8ZWn4PUSDAEf3qkKM4S8X0FSzsJe83i3QA1cJxOXxMD2XyQYmzLSDOnCgwxM5oOpYhIliqZSniT9Ypu2xFUzt3BhuYeAvT6-IQD5wnvxFnHGIDqJDVr5Tiut8ca2DRAFGl-PJw6qpsDM_E3KoHYZCaj6gUvedUty1jBdwSBnHEd_idsMoB-OdXEm_cTsqkNd7LVIk5mAmgt9SLrx5DZ8kyorXXFsOd_xat_wpSPEbRk4ETjUAjeWS0FlSGVWjl9IM3q80VoLNnLjUf8mHz8VCZshsM9xZz7Kv3UIqQAqoHeHzqggExpkvl5i9kUPDHVVepwjAy0xReZ-ky17KR22Wyt_kC9aMh3mkMgBaE4ziMkeJ6hFo7N2t-0DaLF2MyzdgFdoiN1uLd1OJQFyTUtE4xFc5F8Sfi0vg=w1227-h860",
                            DescricaoRestaurante = "Isto é uma descrição do restaurante Porco na Brasa"
                        },
                            new Restaurante()
                        {
                            Nome = "Nau Frutos do Mar",
                            Email = "Teste",
                            Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                            CNPJ = "09.509.467/0001-36",
                            FotoPerfil = "https://lh3.googleusercontent.com/fife/APg5EOZsHspp3z_2hrSIJffaYqFBJvO9Nb6jOxEBK8LL-0d9535_dcl-PWcrkBHxWMuo5gXjOGur2gHw0CmJfXAsMRtP7YRT098e9KGpqAfZG7yhEc14Mc4p065W-HE--6wNM-621YCq0SRifodnd5g-jg6lTdgY7JSUjYlU_3VeWPr1ebIZB8BPalzEUhEoaT-f9wNeBMXiMSPEw1WnMj63Ot9q1L-Jg8kNA18jtJ59xTS3oi9srymAb4HzeILGIlNQOdoP_LljmM3Ibt8WCFJAWTb0e9klWPrWDXzY48l06qA5QEhpvJpJmZBizys3rhy7-ghIzMyDGBxSLuvzpEVT3Q7ynL-nOugZvTcqjQYYpEjcuTFfy5sdw0kMlkK643kpCE5Hkgi55W8vU7MLOtijC0F9QGJBMntKF_njgUZ-ke2mtNBJIz_BGsXSjvSUZb4PlhBSk7qrqZ_49C9Aftrvjb0t2XXYTMAgvbrpe3XlIZjTiOTRnRrV8qF6pPVFJLMSwzxdoTsHKeAReDMnSlqWWYClxpQySTJNF6_brxeJQzTAmAsfLCrF0ATVnCqyyigcUAgAw7UtCcEdbcI10BTUDGX_-4ZT2svU3kDheleMPJCOIeSqPZFZQUCBrxM4oDyDO4lc96uHTlOCVodXP_aWAEjWrFGHlQxzl3mRmgw1RYTlr9QVUstY3bUxoqrg23hUvtJStpAIITgViND1eqwe1o3wiWpY7IyW46VWD2Rt9HH4PpjB16iMqzcT-N7-WjPhnpRUFy0jMly08Wa_OQ-BeWMQEuaZJCJJb1G6QFozcQVlwo-YCAHoXxRv4PVQZk8jZPdJ4DoLNurrbyEFssCLOjpdpwDUIwtL-JTg80jr4cCRdE27ayda8IXge8NUInNllL1KLQdb0ipdRYCecSH2Bgkb71VhzYxqX9Dn9fFX_DEcTXZT7cwNaJ6zJr-ae73seThfcJaeXyiJi_XFoePmYuAV4YIvtPfWQkBZ_FOLx3BnAkqISo9_ibUjq_w_u3Zu3k-r7n6NWfs3vAmVbDPJbLC_P8ZIMGU7sNNiyOXuQLg9LRSpvE7QSZeG1RebB5slbijxV5NHAXltdrSzRfT_hT8ULVg6JOf_ukU0sAkLLcs8gTSnLU8E176ACTs7bcWUIe6oLTv2SeyR9iVTeYTHNgGlwmQ9OWHZNFbRH22wzRa2YDd-GfyBBmJlyj4F8fsdXB7xtytaFqnIws_w4V5RbL37fN8lpsPhCvtmBBBCK6APb2Lr2HBBS8cCXk8iZOeLh82LE6HYdMhuUznFyPMCFgyqoW098haV9-LKtgEfkvWgGUD1PH1_T5zmCou1k7AHbPsWF0I2YKGdb1lGrQXQlDeZe5MWY0Cd4BaC3C9YvDo9sDo7F84xC4YRR0EgkrF5b7qHc3QBIn5Ej3XnDF5QeFUKEmYc41WadlBfej1XA6angs8EMLT_Zo8RIji-hXv-bRDAU47HYs6Lo1NjElnpDlZcnuyUx1HKU37-YoGgAdeNsYrmhTbcxM6PKyHr70gmKD-xTQ=w1227-h860",
                            DescricaoRestaurante = "Isto é uma descrição do restaurante Nau Frutos do Mar"
                        },
                            new Restaurante()
                        {
                            Nome = "Mangai Comida Regional",
                            Email = "Teste",
                            Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                            CNPJ = "49.040.769/0001-22",
                            FotoPerfil = "https://lh3.googleusercontent.com/fife/APg5EOYBu--Z5pv4aKAK3rWvqO1wJNA-Idw_ghbrbVJedHEqMYrHEBvwS5WIokXfOZ8i2dj9H9zUxY-hVBnJZM52HSuma-9tKfo6v1EOybPVkRe-Pvmy_qo3PUc9MEDIu9Wdej2Y8NPtu_HMI7oMOwbSTVtwkAXzyPYFUb2d4zwIXxdMN26GA0Vt5O7kJsrS9YmwlJnZuGwo3P9PVASAfbfybgR2gTstQm_Tf5CPJ0z2TT-RhcNeWsYnjEP1fCDGbaHZL1a56P0j8lcltkyRVLFXIWajAplz8LBilSah38REl12AZFhpcWsLnoVZdddzibENED4SSW6YAA648u4Bg9uhhUaSBGeiN0xuEXYPFt6Acm0z7Dr3DVe3YZzVm7JSsSOqHvjcY78-bvR2-ufK1ypQv_KLj1B5YmNdxk-EKXg2DwTdEKCsWIjFnA2_IdxnoKQem5kWjwJRxHaMrX0tjYVZ1fNAK5kDQ_uD7lnwE5ItEbd51Hg8PQT4hlSpxdBB7WqgffqLUueFsHLYX_0RrbxuSsBrRgwPw4guyhAuiU3mHmcjuQ0iJejorkCGLHc8cTRWne-mP2elgz_eUmSRp-9tuOrxy_NSjFpfBwsF8UlKkkVSDIduR1iLIFf__Z1E8ZQTh1mdOwTCn7-YdYpp5gaLZSJ2XD6v_5dIuW9LZexJhftF6jIaE5MYguCLRwJpSWpCRui6ZyUE3F3tQFB2gUK4g-4zlJvGa75HeyNJcHvX70ENhcjL8ii9oERx3v2s9nKYyTJaQyfWzB8gRWkOt_SYlebVOu55mNuK6MFt3BDEWbXj39Xwu6j2ZaeDnkzrjq0q20jpotoEi3E1duW31zB0VKwD2dHbQ4sNw0eTdaJNbl_weAGlSNmM6IwxwnICMYft_O-cw1dwTX2Ae_3uUxF4hw2YpL0pwm8cp1NGGCVavwSvv9fHeGJHBzkVdlY3z-jI5KLkvR2GUOGLUfVFmlmCNsP51ovQpnBIA6MxHPBMFzu6sKbcQzdGjbjndbJ15KC2vaQBorSqwe6nTW_RlJpFDgJG6tODmQPBYsLYxmmD2R1Ddl3lOOaBY8qf1kPuaMgeCZVjGd7jeg1bwWEto8r4t3-5Gxz5F3CCq0Il0AoOV_qeB_Z8n9oTNBjSPBgriI_A47NhzYCz-u22EkH7kYWnwDWWm_ldOnxcVp2XX3z8q2jGQ5k5xGRDKA9ybJDpOttivzQBJjIviycBt4GrsfDsgMPMASW2lCX5oMbIbW65YIGSMrWTcfL9_rN9t1sElyhBtr4exhuRV63HG0HFT475hfG084t7PqqprlJ21Kg5Jlk4I1AHuqZ-zE16Toehzq1odJ7k40rYS_8bYvIM-xP8MFSeSB2YOaunKAAJLIRkBoRzaLjsAEzLR9gDeCAHEN72bOhc1f__IRqpBIxiduTSI0B2Sb9qiHdDAbPzwfnFMtTMCRUdaSnlf0UyC27-v3tX3MvSkZOvxQf5rfLALAV6sDo5AZPuLaNLRoaB3UJzXULK19fcscSyFm_Lwq5_6YDZyGS91Q=w1227-h860",
                            DescricaoRestaurante = "Isto é uma descrição do restaurante Mangai Comida Regional"
                        }
                    });
                    context.SaveChanges();
                }
                //Clientes
                if (!context.Clientes.Any())
                {
                    context.Clientes.AddRange(new List<Cliente>()
                    {
                        new Cliente() 
                        {
                        Nome = "Jansem Wallemberg",
                        CPF = "100.133.690-91",
                        Foto = "#",
                        Email = "#",
                        Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                        Papel = 0
                        },
                        new Cliente()
                        {
                        Nome = "Natan Fonseca",
                        Email = "Teste",
                        Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                        CPF = "772.521.180-29",
                        Foto = "#",
                        Papel = 0
                        },
                        new Cliente()
                        {
                        Nome = "Wellington Andrade",
                        Email = "Teste",
                        Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                        CPF = "002.289.440-31",
                        Foto = "#",
                        Papel = 0
                        },
                        new Cliente()
                        {
                        Nome = "Neemias Junio",
                        Email = "Teste",
                        Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                        CPF = "587.558.230-84",
                        Foto = "#",
                        Papel = 0
                        },
                        new Cliente()
                        {
                        Nome = "Aabrão da Silva",
                        Email = "Teste",
                        Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                        CPF = "577.613.270-33",
                        Foto = "#",
                        Papel = 0
                        },
                        new Cliente()
                        {
                        Nome = "Pedro Ferreira",
                        Email = "Teste",
                        Senha = BCrypt.Net.BCrypt.HashPassword("Teste"),
                        CPF = "139.956.700-40",
                        Foto = "#",
                        Papel = 0
                        }
                    });
                    context.SaveChanges();
                }

                //Comentarios
                if (!context.Comentarios.Any())
                {
                    context.Comentarios.AddRange(new List<Comentario>()
                    {
                        new Comentario()
                        {
                            DataCriacao = DateTime.Now.AddDays(-10),
                            ConteudoComentario = "Lorem ipsum volutpat dolor amet purus nibh rutrum phasellus tortor, suspendisse nam suspendisse etiam integer velit luctus. porta inceptos sit aliquet nullam nulla aliquam habitasse, porttitor felis diam dapibus et dictumst turpis, ornare sociosqu integer quis vulputate ut. nunc dolor facilisis vulputate risus cursus in adipiscing nunc donec nulla, tincidunt dui gravida fringilla turpis posuere curabitur mauris hac, augue curabitur quisque vulputate cras sit eu velit praesent. augue risus porttitor netus quisque arcu porta tempus condimentum accumsan sociosqu, tempus donec nunc tortor varius consequat id egestas dolor. sapien habitasse mollis auctor viverra sagittis nisl pulvinar, luctus bibendum nullam volutpat leo. ",
                            ClienteId = 1,
                            RestauranteId = 4
                        },
                        new Comentario()
                        {
                            DataCriacao = DateTime.Now.AddDays(-30),
                            ConteudoComentario = "Lorem ipsum volutpat dolor amet purus nibh rutrum phasellus tortor, suspendisse nam suspendisse etiam integer velit luctus. porta inceptos sit aliquet nullam nulla aliquam habitasse, porttitor felis diam dapibus et dictumst turpis, ornare sociosqu integer quis vulputate ut. nunc dolor facilisis vulputate risus cursus in adipiscing nunc donec nulla, tincidunt dui gravida fringilla turpis posuere curabitur mauris hac, augue curabitur quisque vulputate cras sit eu velit praesent. augue risus porttitor netus quisque arcu porta tempus condimentum accumsan sociosqu, tempus donec nunc tortor varius consequat id egestas dolor. sapien habitasse mollis auctor viverra sagittis nisl pulvinar, luctus bibendum nullam volutpat leo. ",
                            ClienteId = 2,
                            RestauranteId = 3
                        },
                        new Comentario()
                        {
                            DataCriacao = DateTime.Now.AddDays(-2),
                            ConteudoComentario = "Lorem ipsum volutpat dolor amet purus nibh rutrum phasellus tortor, suspendisse nam suspendisse etiam integer velit luctus. porta inceptos sit aliquet nullam nulla aliquam habitasse, porttitor felis diam dapibus et dictumst turpis, ornare sociosqu integer quis vulputate ut. nunc dolor facilisis vulputate risus cursus in adipiscing nunc donec nulla, tincidunt dui gravida fringilla turpis posuere curabitur mauris hac, augue curabitur quisque vulputate cras sit eu velit praesent. augue risus porttitor netus quisque arcu porta tempus condimentum accumsan sociosqu, tempus donec nunc tortor varius consequat id egestas dolor. sapien habitasse mollis auctor viverra sagittis nisl pulvinar, luctus bibendum nullam volutpat leo. ",
                            ClienteId = 3,
                            RestauranteId = 1
                        },
                        new Comentario()
                        {
                            DataCriacao = DateTime.Now.AddDays(-5),
                            ConteudoComentario = "Lorem ipsum volutpat dolor amet purus nibh rutrum phasellus tortor, suspendisse nam suspendisse etiam integer velit luctus. porta inceptos sit aliquet nullam nulla aliquam habitasse, porttitor felis diam dapibus et dictumst turpis, ornare sociosqu integer quis vulputate ut. nunc dolor facilisis vulputate risus cursus in adipiscing nunc donec nulla, tincidunt dui gravida fringilla turpis posuere curabitur mauris hac, augue curabitur quisque vulputate cras sit eu velit praesent. augue risus porttitor netus quisque arcu porta tempus condimentum accumsan sociosqu, tempus donec nunc tortor varius consequat id egestas dolor. sapien habitasse mollis auctor viverra sagittis nisl pulvinar, luctus bibendum nullam volutpat leo. ",
                            ClienteId = 4,
                            RestauranteId = 3
                        }

                    });
                    context.SaveChanges();
                }
                //Enderecos
                if (!context.Enderecos.Any())
                {
                    context.Enderecos.AddRange(new List<Endereco>()
                    {
                        new Endereco() 
                        {
                        Logradouro ="Rua Roberto Paschoal Borgatto",
                        Numero = "959",
                        Complemento = "Loja 2",
                        CEP ="14164-025",
                        Bairro ="Jardim Liberdade",
                        Cidade = "Sertãozinho",
                        Estado = "SP",
                        RestauranteId = 1

                        },
                        new Endereco()
                        {
                        Logradouro ="Rua Maria de Sousa Soares",
                        Numero = "126",
                        Complemento = "Loja 1",
                        CEP ="36300-338",
                        Bairro ="Santa Maria",
                        Cidade = "Sete Lagoas",
                        Estado = "MG",
                        RestauranteId = 2
                        },
                        new Endereco()
                        {
                        Logradouro ="Rua Margem da Ferrovia",
                        Numero = "720",
                        Complemento = "",
                        CEP ="33045-155",
                        Bairro ="Frimisa",
                        Cidade = "Santa Luzia",
                        Estado = "MG",
                        RestauranteId = 3
                        },
                        new Endereco()
                        {
                        Logradouro ="Rua H-1",
                        Numero = "751",
                        Complemento = "20 Andar",
                        CEP ="35024-840",
                        Bairro ="Sir",
                        Cidade = "Governador Valadares",
                        Estado = "MG",
                        RestauranteId = 4
                        },
                        new Endereco()
                        {
                        Logradouro ="Rua Wagner Melo Mendes",
                        Numero = "532",
                        Complemento = "",
                        CEP ="31620-265",
                        Bairro ="Europa",
                        Cidade = "Belo Horizonte",
                        Estado = "MG",
                        RestauranteId = 5
                        },
                        new Endereco()
                        {
                        Logradouro ="Travessa Odilon Cristaldo",
                        Numero = "934",
                        Complemento = "",
                        CEP ="38303-235",
                        Bairro ="Residencial Portal dos Ipês",
                        Cidade = "Ituiutaba",
                        Estado = "MG",
                        RestauranteId = 6
                        }

                    });
                    context.SaveChanges();
                }
                //Especialidades
                if (!context.Especialidades.Any())
                {
                    context.Especialidades.AddRange(new List<Especialidade>()
                    {
                        new Especialidade() 
                        { 
                        NomeEspecialidade = "Brasileira",
                        ImagemUpload = "./img/especialidade/Brasileira.png",
                        DataCadastro = DateTime.Now.AddDays(-2)
                        },
                        new Especialidade()
                        {
                        NomeEspecialidade = "Francesa",
                        ImagemUpload = "./img/especialidade/Francesa.png",
                        DataCadastro = DateTime.Now.AddDays(-2)
                        },new Especialidade()
                        {
                        NomeEspecialidade = "Japonesa",
                        ImagemUpload = "./img/especialidade/Japonesa.png",
                        DataCadastro = DateTime.Now.AddDays(-2)
                        },
                        new Especialidade()
                        {
                        NomeEspecialidade = "Árabe",
                        ImagemUpload = "./img/especialidade/Arabe.png",
                        DataCadastro = DateTime.Now.AddDays(-2)
                        },new Especialidade()
                        {
                        NomeEspecialidade = "Vegetariana",
                        ImagemUpload = "./img/especialidade/Vegetariana.png",
                        DataCadastro = DateTime.Now.AddDays(-2)
                        },new Especialidade()
                        {
                        NomeEspecialidade = "Mexicana",
                        ImagemUpload = "./img/especialidade/Mexicana.png",
                        DataCadastro = DateTime.Now.AddDays(-2)
                        },new Especialidade()
                        {
                        NomeEspecialidade = "Indiana",
                        ImagemUpload = "./img/especialidade/Indiana.png",
                        DataCadastro = DateTime.Now.AddDays(-2)
                        },new Especialidade()
                        {
                        NomeEspecialidade = "Sobremesa",
                        ImagemUpload = "./img/especialidade/Sobremesa.png",
                        DataCadastro = DateTime.Now.AddDays(-2)
                        }

                    });
                    context.SaveChanges();
                }
                //Especialidades_Clientes
                if (!context.Especialidades_Clientes.Any())
                {
                    context.Especialidades_Clientes.AddRange(new List<Especialidade_Cliente>()
                    {
                        new Especialidade_Cliente()
                        {
                            ClienteId = 1,
                            EspecialidadeId = 1
                        },
                        new Especialidade_Cliente()
                        {
                            ClienteId = 1,
                            EspecialidadeId = 2
                        },
                        new Especialidade_Cliente()
                        {
                            ClienteId = 2,
                            EspecialidadeId= 3
                        },
                        new Especialidade_Cliente()
                        {
                            ClienteId = 2,
                            EspecialidadeId = 4
                        },
                        new Especialidade_Cliente()
                        {
                            ClienteId = 3,
                            EspecialidadeId = 5
                        },
                        new Especialidade_Cliente()
                        {
                            ClienteId = 4,
                            EspecialidadeId = 4
                        },
                        new Especialidade_Cliente()
                        {
                            ClienteId = 6,
                            EspecialidadeId = 6
                        },
                        new Especialidade_Cliente()
                        {
                            ClienteId = 5,
                            EspecialidadeId = 6
                        },
                        new Especialidade_Cliente()
                        {
                            ClienteId = 5,
                            EspecialidadeId = 4
                        }
                    });
                    context.SaveChanges();
                }

                //Especialidades_Restaurantes
                if (!context.Especialidades_Restaurantes.Any())
                {
                    context.Especialidades_Restaurantes.AddRange(new List<Especialidade_Restaurante>()
                    {
                        new Especialidade_Restaurante ()
                        {
                            RestauranteId= 1,
                            EspecialidadeId= 6
                        },
                         new Especialidade_Restaurante ()
                        {
                            RestauranteId= 2,
                            EspecialidadeId= 6
                        },
                          new Especialidade_Restaurante ()
                        {
                            RestauranteId= 3,
                            EspecialidadeId= 5
                        },
                           new Especialidade_Restaurante ()
                        {
                            RestauranteId= 4,
                            EspecialidadeId= 4
                        },
                            new Especialidade_Restaurante ()
                        {
                            RestauranteId= 5,
                            EspecialidadeId= 3
                        },
                             new Especialidade_Restaurante ()
                        {
                            RestauranteId= 6,
                            EspecialidadeId= 4
                        }
                    });
                    context.SaveChanges();
                }
                //Fotos
                if (!context.Fotos.Any())
                {
                    context.Fotos.AddRange(new List<Foto>()
                    {
                        new Foto ()
                        {
                            FotosRestaurante="https://lh3.googleusercontent.com/fife/APg5EOZ4gC2l9Qd6VnLwDM3mMyxfgV5NWGXXQ_07cYa3-kz50MrR_AfkLo8xTFLBQAInRIyFddALlji1ANtbedrM2t9pABzJYkBcFQVOkEwoovJHC1EftRguWCxtp4efpgUqD7o88_Q-GNmqHfqE_ihI8QcY563Vf9LdiDRJpdqwYH3-LzovqlN5p5698PMS0XSLYx861N_4JKG8Zl6kpUkjyltPCan9STsOvGXziOeegF_bM0qwksm-aA8GLhd8ineJSaRWkArTHhU3hS5hgxPh3rmZAZ9-AeLeOXG2u7GXKt5DDZ67uZnF2hV3SH4EPSnT4gPPeGj5D96oElgE0_doIOIBHGZm3eV-_drMpOu-r_lXu8kMdLZO1Wu6AWT55DFLlRaxa_5qqSYl11XCXdm4tZU-CYSdE85zKHj99vtF2_OEmkJWyMOkBWYXdlmC43j6pSnWfV_73-YDjiycRJ-aAd39QgrNzW8Mfm-9PQgCH5OXlCqfuvxtxspEfGQWh4mm6aOwGXxNseKFZl83fyNuyaS0UbkMQg44dPChYO0ZCl0XnzxaYbXRsnYhKzLp61_ZZFnqyWEW0SIigrNZ4_fOtUChYHpSzqlzkOQtlWPhLONXT8wXGzHYCz5sc13-hbYFbueGD8MJqJZO9zKyAmZZxeqh9bhF_OVcr7_aCsuo0bLey-xjCM4SN8KUZQNfVJ-Vb41rDl9H4EIkCE7ZpKsUXcRPzDMHGI2cZZwW4PzSFsi6P7hxCk63GSYpxDiFBKpoxpfn7UnqcRlCcc2yJ8x8h8CDvR1FFzTHcyXML8YvKRvoec10N6i0ZRObDk5jEhCEvW_qDg-HSxI6On144zXn-x8Utpl6sUHf0yOteWR1eZpdazvhlnU-Odm8pRy4JFVp85znxdmIU0ZiQSJmh1abmLAUA4aGYZu66afE9prnv7D6HrYNyjIkENNKJCISR_9aQIkYyhY4keVnsdcCktfZ-pz5nGA6GCWCkA_UDbDp7CnnBL5rjamlghX6NLLCANSBb48THwXmpfZhrdkAH-JizsZ_01v3YIkAvcKEtrSqvTHZzMREvg_H0M3-WC7NQYUtbs7cKSX3qguxR_oREilHZmfiHb2yLzff9IiWcnBG5_zTsY1zf_ylVqNiuf-IL6F0zABAzepeAprMI-3oEi2H8HezGsibtlGLQSw_i_4nCCDtCBYdqvwd5bOjOuJwYcc3HHp8K8P9IfK5aOX5h7gcSgXMk_PTcsOoxykdJ1GDFzryf55kDjeYmlvw-tYaKy4bHNHi0KfDbBVx7DjNRN_sk6kQoaWpczt5FjCBGGCOa-6Sc2Wi367kJh7N_x55puqDGzazfBL-ErZlmduika7gF3hmwMvL_VMbOHlx0APIt8hJkQrJEYL1vfQJ9uZ7Ma3sUXMweTfzIcXNzvJ_PDQG7rcAUM52lOq6sMskmWVJ6bTaHAl8YWhl8_Ky317NBwEn6xpE8tJJDqJ4RyTXrhpsDrrsrLvbsIfQttzMGThJtKhCokluzx_l2B_jj0JisX2iCPrKKA=w1227-h860",
                            RestauranteId= 1
                        },
                        new Foto ()
                        {
                            FotosRestaurante="https://lh3.googleusercontent.com/fife/APg5EOYATCW1QD3KEgOucGPoZxAkudo1HHyXezWkQqBu7FFt89kke1tMbEn7ld2NczayolRiECzpk_tnsRS53hedKoZlEToNnews1zZVqqbrXz-oyL0K6qLus-FyJsCDjl1IK48h3U63fVo4b_brks8u4CegrFsV_ayqLHxnX_u7eLusWjHuleh-3xPkv9FFWYCBzUPMJxwH7YUktW-vTxOjtIKOeNF9D59nYG_-eEzn2DcKRg1VswlKdNTH04ixHaTxo-reW749qn8gCk77JV8WAJcCYTu3Ly-sZ0RTvch4o4xmvLEVI6CD-en_yoGzdTAn6YIbXcGqG5EEzSDu9Vccudgq_O0y_A573f-Lcw3WwDxVpDnvQxUhTifQNaFdf_DSnJyDzWqfW_LK48HTQTHLZHWSbl04r69jWOaLkbQ1pcUw042-sqD1Autms9iZAbAWTPzGEDLeO97uikQMy1VttuW9uEp8AYnCj4iXehhAa6ktE_XwWuGQ6nq7kkMKWR3n7l1RObCpNMjTyrKXPoaloppcMMYA681jEYHVmA1bnQOq7WaHP9Dysz_j6_LNqXtBWYaEgf0A9iBQvr8tOJdG6ZdGFzHgT1-K5JYbeJ_CerG5RswAsJ-mmr0H35yRIGnyYrsZKWCG6J1CsBXj6rvSTfqBGwFyUs4G6MI8PenkHfFvTQbY4zYiR1yEMKt8CM2mOP8axE1mprxkOpxadwHMaxPxSrzEFKeU6J9mRPYU9YCF87UbmQlowL95-8BVXEVQ8i5WvIRrnYJpSuyzgoTl6bS_CRwIXVhcfHvqBCu-YvhGBgW37C2ZiKpNZNHHkyvPXwbKiB3c3Y1dO-5CfhjW4s1C3oN7kaAx0EPImen5JycXc60Is-ejieS2kDHXD_msjE0w-gVG46oDSXNgaVH4cdjtej9dmlwev4FdUMsWv03eLBu5frk8ykAvQIcR9WmPC3njUxzd6e1tsCjFHEesbWyo0F2-twZx4QY8IKYSQQlU1NoMjXFgDV1kVfpcodn8V50bHsdqKi9U3NebOWod2sOEY0kJmGjw3SiYtmw8fBOg_BFqGzvKhGHpHmlnBDQv6CM5mIYgO1fUlK6O1E77ZqvNCOFNFuUKgeKMQHer3egmBIyXhLWkWppMflwLOMP7OM1sDNsVUZrb3vvm99icZKbaPtdKg6xdmNGznNwvE7_IDtoCCZB11P8LC8js7WdoLJlpwaHMH-AQ8WjjaTu2jx53mLUvz1a-m2jKJPH66JiUANHEbmlm31yOsR-La3DGx424OF9u-HmMO9R31HBBucbHmyyLqnibV58kehaT_qd_LSGziCHHsgcefse0T-2scUSoMbiifHJnhi485Uh9NNyMw2YbfAWoAHuJsjrZRPsKfwyWQVrI-TbDJRtmgjvFB2eLb2NfCLaDMh8_rOspqZY4oF3cXont8GOK0aqH4ZHOl8-vu0aAMvHHMlmDtSdE6xEUo83VJzD0c0YpGtqGTvLROy4NkmmLiLFBwdHDGfLxK1BNQ4y_KfwLlKQjHjiAcuDUTg=w1227-h860",
                            RestauranteId= 1
                        },
                        new Foto ()
                        {
                            FotosRestaurante="https://lh3.googleusercontent.com/fife/APg5EOaO5dTYCmRhZpwV85YlKS4OmM3vlnVGT_qaUK_Cs7RFut1Jd7adPdQqeB5XqACvpapkZt5jG5IQlhQYt6s7JemrlQjAwc6_DHB_0jCiHeaWcj0Bbw0LwwebRVCyw_opyG_RrJ7EzMYQPPZwUXeOqYr3QYolOjJrySYfYXH_Z1A1cV-Xu8ZazLCuV543HwZCpXI_s87EzFxKGhnaYU5h6F4I8_nTmACHFp9C1OTV4mKkebUIUYXYat0pOtqsghOZe-H5fq3zssfTQT8G8XYLL6aHQ-2U4jgN8eu8jpwC82m66tWFig-crI2Yoiz8NBstGgO4473nH5QFYAmsUGNkvhac3KWLd3Kg7cMDxO4RO8XNTfIn0yCzZZyLZRwHP7Q8nKu2qjtefvSLLdDmh_DzR1DsNoRixVO4Ek4r89R5Cu-FB7cWlBv48CwZdLqmf09fKEKZa_cFv-UfXwt9T8ORGJBC0SfofQzg6NHs3zHExjl8Loaw6nrjaPfQhw42XEH7o3K5mHrRZbSAyTRwAG9YclPIXygzFFggWAmkbNDqTkyShrEFThERN0UxVwXM58hY8sU6gaBnAzW3OKsfF_CZl9k8V_A8hAN2PKyJYi1-oKQRT8VXWd_cK2-k5PeCPc82fkUcxn7T_BcZrUcUB3B8llcRl48kyBwH4lPXU2z6QnEiLzX2mS7eKvzEkc8sP6bpc8YZn3PLNF9VBjqS3UCgJ8hGl8kL9SEClwMQcDjodi1rhBNuP0-U4c08RjLVPo2g0oqDJUEcWxqmNUsRQGPjDVwVCNP4hRYYvCLKD8peP2vigzhl-_hvyOP9wKHQv4g8r1oqK5z4awXFQT-6Pov9iH_0V7yxt5H9IGi_WQ2sEcecaM3u80G0qFJRv8jQDKTZq6T6sVbeOM0thBXn_q7IuXXDrODKIVOly5gH156sQbI4u8U-wjaJ-efWLOzRYEHbYqV4hwSSqQfJ0141sDDTuPvfAlvlJC2DUSbhi9lQwPWd2wcmrYYdp_UvfBRKL4YFyLXOx2tJMwsfQJ9vghmFXZz_HhKqab5zvSYxncAAuJ_wMOQsv0RMgiTf3vqVLyh96Sg2fYBERIGrLJqC9W9RBWNtDy98YTh50z8tXpycy__7MG47ivZC7X0Eatf225EkKv9DBnG7qYM4_9Mb2-Wt8g-3DBMot-TYaJ5pqeT10WIJ35O30b-7LzbuUHInRCYxCL9GPUtLzd2HMdS45EvwADMbqYIU4PQ0DG2cPXB5vdS0VocqKp3P23qY0BQJN-ac9QiQxWxvYC7D9qhL-knxjEx6xmXQNb7Cb3Pix_xWQaCtmKGLzVSnjufHFBHvUe-aiM9R5uQ99dGMIssY2nmYnXQkf79xFWWtuBGqnTjaUXNj6ycRHykEcVPhAiXUnF67lBNNhsBQYk9CoR_8CsAQB_FT8GUHxLliGR9836g-XmtnI5VuB5SO4VCcyAA2-unIxqBdNsjFbMuUMey-m5WXOwDbUNCkvvxqO3TohhxVGQ5rXBM-ljBrTm-ITIOEWTi57BkWsA=w1227-h860",
                            RestauranteId= 2
                        },
                        new Foto ()
                        {
                            FotosRestaurante="https://lh3.googleusercontent.com/fife/APg5EOZ06p2rJ7IZM1yj6m-yZvKFlhBhp0CyuDu8oeqC8JAEEYEYOQkNawSbz4RmeZvQBThV0-YBzshCOoZyGWxXbSgLWRkCO73gR8AdyCOZKkhrLSwgepwZS49XOVv3Xz0IPYLdS-kp8gajD2p1ZT9bXqoZvSGXdWwerakpasNB9PyWJq9MxPootsoAPUEPGxtnF5y6WTpYLyuyK5XU1vS0xD9EKJFazOQOhUc0bd9v0Kl3MaZ6h4P4EHydIiDHcpqxxYUYyMVVsX0MvHpmRWJd9yeqx35rer5LdjAfeMlDCxN3NpW1qfGLob5BzHeJSr4SibyW5foMlN2bN0AjjVLzaATIEhFzjWi7vI1S5YRfifJT_ydRebFXEfD-0shG59T_hNxXk3HuggpaecBvjz8JjochAumathBtUsSAuHzc3t1auzAuG1bNDjKjrKhURPVkL43kFaORlGem7teDiFM_LyRyUXsnpxgpbkEFnTJB194SZ53pdhxoixhRCG4lBRqrUW56w3Y9nzgJg0U-zLUZ5ZLEZHZ58YgvwFJwQvya2agANO69sqe4sLR7hDUoslPH7krwNGr9sgtTH8R8mtDo2M7ryiltReZCbPWD6o3nXr5xcZsa0OtA152lWFpqRGY41-rt7HvHpGqDSg1Klqog4_qp9HIiApXm1ZwEqDVR6v_-usb4MRjjwZK5IxYbFnfCLCrBGx2Dky5Sq0QX-1y97FUXnB3L16WsocjjVtu6mfA84C2Ogze3RwCR9P4-UgCVZ4ewYw1Px0Hj7--bYkTh_8FwDpOwvnHocOPhim3-CPViiJqer6TBQ2_0XAMiHf7RArZKVsd9oWp5paLsQ-qOs99ikHblJ5_dMYOu8P2TVALkeG8y9MNbLWkZooTBTP0imT2PwbjPDLsPkafcNIchsdu2P8tbQUsO3y3vbt54zCs_G-njjFEbETB9dSovisb8rLnDhJxfKQCGR_9jeXU1_LhTAhQP0YHT_A-xb4P0fslXAEhcwGQV9Vei5geLUfMgbU3RpvWcKHME86VkUVjtylLkMzdcyQNN37NMA_dNQEgwzHaYTETzzoUeyH12F1CLuzIJZpJUAhjfC_WAtZdXBwPcgyYdTzK7OEZOGy7c3E6KPFXq_kqR57O_N7jwprCqIsJmGqDpIzsvuBYANX8jeVueJGFBAJtvNUcShTgtMFGHWaagv_dGgVoui-drvriLpqu0lF-qVbLePnESB3ibWv7b1IrOpLoAnRgrUrhdxvP2tZVnaBgd6wMpZhJSoXPoaoo_UbE2jXA86jaMYtFhYxXPIF8rd3dNmwsjo3OdqWg_xk1rcq8u85vTulZAiSCzCEf2h8enO-wpbjqkSg_WUX9D41x8sijWSaDQVYNvTGxCL9xExOnhqiC1o93Q1jxI6uLAd7k-i-9GXDEAa8YMyoQsA4qemx_ostrnSgxSGTiLM0G6HS_GOUKZ0y7VQBEFW6zB_jktu9OpIMh2FGikITPIDBROvpGT8b2e2QTzm4dElRPCgOa4whX57EgiJY4IsAu1VQ=w1227-h860",
                            RestauranteId= 2
                        },
                        new Foto ()
                        {
                            FotosRestaurante="https://lh3.googleusercontent.com/fife/APg5EOZ2C3BlPAXmXIfLvjn8-sdUWEdcKrz3Auj4ZkBN9xbXurH0YxZWJzVzYXyONImrpIuraZhvD0-wWXK9tc0EsdBgPYfn_FDQ24-ixT56ru51W4kgv6mlZr7aHC86U929hOttw2S6qf7QHGtGgIxI1IK61s3FeJ8YhCa-CDLqexWKBSRkyQDqWktZrS8r4-r_RdH2WQ1YAnfTB1Qh6P41DA7BAzLZwdDltnzrHnoADOPIFtn5wTGnPRTyAYvuG787zWz4eRl3kgXV50H0kVtfRHVRAxMfP0oDuN5Xk3CqJFHqfAa2PP1mCKfIyVTYmlVLyvORA7MTRVzW8mozh1QhXWJhPJnMkuitc5vkvhp79UwxLOyr3aWagYyyYcXqXCoJ7IvUWbxTH4BRsQkHyojLm9NJ6c2TGmV3U22cmZifj1SD2AZI0LwXbqCDRKZHnL-PxS7qpbVUNkOx4e6ybISiaPM2ck3vC4bwxL-Q1FbF31I0cHrK2wreGgUVDxamNVyMPBunnO_cN5qJrSkK9EGEbTKoscjl7dAHnZ8z0_iJ_6DS7FH_IJQzY2aZQx3K7amO9UxTKz1tLXLyOVod9pVowTaPKo-p8sOOKs3TEjLalAWTwYbXjFwxVm11fOBE3uRSg2nPP27-UiIFZ7NVDVk8tsqGeNGqDexpWE5viCJnmfczUisGN1tXAvR4PzDwF5TLZt2Bkrm2o7z8atkAIrqntUFiSud16z6adv6n4W-cpE_JZ-V4QTOKHUwyZ8FgT8ZqDcWWJED4VOnhHaZjn5RpEOq_1MVq445LgDzZIevEAwVDtob3hs_R-F6gg4z_UJHu-kSYhj4iCO7ZOzroRo6uhiFbUWyHblvVZBWfeBCmL8DjGONATjzlDiTqmyj0faGG9RiNa83OtBF9Dvr1f-se1qE27T8ggWM4pnYHCaLfBAPWKXh2CLftNr6BH5iSRJ0aGUyFaY0GKyVj8oN6WdgOIwtqWDs3CSvQfdJCiNeVPwWWDhIjOo-rDPuwQ7DtItyVBQE1C-qyauPPkWmzgiJtKpDlS8qpsbwunDRfdZ5NTnlLvPjxiWGWz06KIhCN9CWTqfPi-_IWyhy2eN7Z6xLUMkXz2LJk3coFtABSQAFk3ttmkYwChEm8RX0uuxLXkFcFT-AOhnXH63zZ0HwI__HERitm_s1MXu8gZ_1_ajEjlWg0tlDjPQoKHxiPbRaIecl0GQdn55DJ4Bsgv3vVZb7LEinn-1UkxJbSeEfg4198O6iTW02DKNnS-Oxf6uxssWFfo6QgpxX6vPuuP5FWEsCSBdunknVQJtZwG-PfibHHZNGvIWM0d-t0PXwFSvjDHwjvJTHSpnbv-S_lI0B2Cf4O2ELRQISYpLTQ8eI_WBncmmAB2WuOPWaceuCWNqhzsWH4NCw-yeLeUE-mG-GZ9jgO3q8IVElnUwD17E0LDE0QUvDAjd0BgHSX2723eP13-F_wZfaJtVMglAksZEz_bLRrKlsTpTVh2gh-dXgmCKOUNOT2fhYxuor2Wdax03C6ajePQAzJBQ=w1227-h860",
                            RestauranteId= 3
                        },
                        new Foto ()
                        {
                            FotosRestaurante="https://lh3.googleusercontent.com/fife/APg5EOZV6__gZEXvlNg9Gt9nFQUkr7WW7Zi1s_QUchvBpTwBHNJN_0SiJUWUIwvi9E9dbsT7CYBLVk6lYyaHdXr85PdQNy25wEDj4GjNoJI9dch58qMVBvP3O_0VeOP1ApIELyzEKJzvlfYuEqv-_19V42hWxoxfj3U8pgiBDleSlysKVjBrB4Omggi6DHsFdckL-7cazuItZGptdEKH1qhemR7E-QmBCHrJ64Dqy6twRX9WmzKH0wsE_ibYw9KeKSAD-tT_qLVuCvNuJ5Ph5dYNRwlGNEDFXz0unFJIXIrhb0SlClSoNoN4D_koNPzg_zlxCgXfQl2wWCudhgUUhrVcMDGMQQS10dPrVoRMwsh9ssqgQ8BeRjlZGv-u89ts9IPtF4MdLju5cHZb1ZawLh96f0MUHCVo5_Gi3IzsxA1Np7O3PZGyNI8k7pqUzF3U7BGPqr7EhWr3snj1mICwV0NFx7Eh3bnWUabDwdXEU8mFj1TYOHMljrQXJfXGHMmmVTP-0MIBgE_DuHdv7S6yr0FuApo3_6Gf9p0vKuCMCXrsf6o5Ibb6kLyKavRbLM-gpppONTH6pYh_4rkk2INkyyNkz0q_5tptus6vCdY-Ki6HNkqGvPmrS1tO8l_fNrA3aXT0XzsC6QStsVL_1m2E6fIbO5bzE2tH7YCdj8c0hwJsYYEXEN63UEiAsli8EKB6mQyekd1yjP9Vj5XDZ7r2gvZdeXAHshSV-YKFlQBP2Wxh7gwB_YGVPtoFsEjQ9vYK_maLQdEyiHgaK0oQnU4azvPG1vJoE5NqxCbm-W4YJNFySZ34uo1uS4WtqSiG-aq2Z2F8F3wbcJzOHve88I4rWn1e4Sse2yxPBFm-lLaVFsrVObeZj3ZPU0ntH5Gn04CkyR01V6bZd4izG-0Ttw48jz2964zI5Tiux3T0AGMUcLlOjq-GV9YteUzBLqyDay2EftFwZ3cpDpRU7Y6iCtKN2sKm9i4xp6bUrzlHO5K03E9pZCtqd90jbk0NULszphSyMu0YQvo14s7cDHqAEmVeG6eHTknGDTqgvTJksgIXLFqxzemkw36zK-_Gsk-NImwKH7K7yvJUcCDECQXr0jZMZJser8Hui90mdBxqcO7v0I9HwgZg0hc2fR2_E8UaSwnDyEMdXg5MobcEtJNBq2VXSvhegBgV-OApAxQyM_XnQ_K3TdTovJs_gDOHxIfXeaBOdRelYcAVllic-CmkNONCTu5mZb6tYdsFz7qxHlbpSGedB87cR89WMxnmJTvlDRzf78QYI1PMlpe389S6R_TkwdaZkBRSNsuRKRciIELuNtyjhzawoQEdCsYwhNQ-KSeRZIZhv3fdADWeJtiH04e77NG46VqSsPs1xMynaQKsj-neTD4jcCKxDCAcgDsl76P-BqRzAQXgAlKAc9y3Lw88ULN7R4GrEdTJkoWJouriJGuipqgU4yO2gp7THy_pT1sO3O3Vp6lGiLYhgwgM130Qx3NIfpbifj_GYmA8t9RGAII4t1L8asV1Xc8YSuMgxzPPCVmqIRsRZQ=w1227-h860",
                            RestauranteId= 3
                        },
                        new Foto ()
                        {
                            FotosRestaurante="https://lh3.googleusercontent.com/fife/APg5EObKJhd4XmRIQoQiyvjEcPd06Cl8dwN-7iHv7OhLNDkt6LI8dr4jqRie25jPxQVTSXKrcKLuxyVQEUhVFY047Tis9zvLEGuJIp9IHTJgicc4QIQGY450xMt-NK8aqa78hvJfYvNcCM33NYuowHUnCFCzJ-ZzuDXyGwY6tvVJ98aKXSTcfZS9EnobkqHLoZwdZ2_l4rlqp_uBqqKNtLkc2gQV9XGFfzUD5Icm_CHgcZD5mWac9AvK1seKtCGCwhgPUfBcCcn--P9CqThx4pPCW_ZDDwE4nFHciqHC1qVRxl4Kh_4cnGtddmflSIeneFsoZivwFXgwDkMijBhfN0oASjyCz7IBWzkZpa-dy6cy7RrBjyb1zto_so4ReK3y84M5EfgWXu3FyHBQ0qUFELzbaBxmSzmIxGNmmShw63nMvNzlVzt5mWWaqe10fA9o0ixsRvfFT4oUUCa9mlThoZd1_kokfDtw726gwRGSr0Rm54cC47-uQiKOiXzqLnUxRde1flg6NI5wWDv4z6yFjCUttJzqBzfH3H_F2e4OYp6BVEDCVYRiVmLtWWStaDilRlbwdqOJ3jZEEEh2NHzJ7fD6xyb5v4RuMitx_N58z2b55wsJYOlI_lqjOYmlo58N5O4uxjMyNqv8dCMdZsWJ1U04u4OPBrMibS2QQLvaoZD3KoLughgz4noRDX6qaW5oowSbE_gN83_4sAfsCXAKDMBR3SyKu6PO9-COySSM24r3e4RNCRhBGmwwBNjc5yRsRhXDO0DDjPzZboGOwcQfIF1s1EmPCFC1B0e-hGnVT0uK_OeoVc0vVTEsMr2UVW4VRqdaaRtO3L8r30rXtTX34vQ2MqhFZ5zOsM_cWipl3w3HKcdfb03d5B7IxSf8aKEvl6DkHGNNm1myzApBIvfYBlPZSDFDx27ymk-b9_r-Ibk3ruXbbk6AZoTykDzxDr-DgbdDF-XYGCt6ou4kDa5mX1exzvrRX-6HHw9Jcq_iPUmX34GBz_bJ68_67k0tgWUYJd9jJIXyxdDlKIipUTCWyV4nTK2y0VaoXwtkTmBU2MSBT1YcYciUA07jv0btn5t48q_oznuy8kY_NGLz9fRrhs-JHjvvhJGs1c_MGeTnVVSQ2eazLP3UrIg22cHL7pWVabhjbufhaFIgqEREjwwPsPwW3GsexzsG-d6WALmyNBBhJlxuR-HJTvzgQTW75iftn60vq-gKl5kOdPpnRU3VuVz6NiVHczcVghOdU1bqvECCkT9Xlx7Un3mChzxCczZGBSFf3nPr5YDCViuecCAFhE58kVNxfd-zCy0_rU4KEBkHG-qTAi353f5FkotX9n1svqVjm3hwrHlGAWl3_W8wissbSmW3kYPeK_9uwWFiehs-B393EoS7AgzhQtazqOaL-xdWXtYD1fJa8OVg9vSjQkXRfHGfaOmpOai5scCqm2X-WXTVmMYWoFA_0eKeLfUI1yPJeVBh7VvOUebYpfixSpDodbDl4zqwpYkKDHkuRuZYIDCmgaskdCArDfrYZKvvlEj_90fsCw=w1227-h860",
                            RestauranteId= 4
                        },
                        new Foto ()
                        {
                            FotosRestaurante="https://lh3.googleusercontent.com/fife/APg5EOYT411MAaFHIue1aqvF5GZc_7zf5cIe14eFa7p7u_WXQzYQlR-sqvKrDLosuQbUgtrzG1pYxfRmI01VGhZnoAkIKbvjoD4StgL_Pk0K-YytzKpJZyyuOJYFfeig8soBYn1utOD9ncFUpipSrMYeYkSMr65HO3VOu6NyhYRgpZYJXJpHxeFxDy2kmMskSPKPP-chl3RtJYntFqpJawacU-yoePN50DHdXS8swz7Z5EeaAbKoXkzP-ijI9fDj8LyRui6IamtMKuAMOWkJwmQH_9uW0AuDx25Prza7clMKmjKRBtxI4_72WnHdwn3zz9KPdVqdEzr2BQdZ0rRMYA6c45AiSWgu7H3ZcMh-bPJHHdh4ruzJKU3kv0ANA8yPV-NHDlfywpMmjN7um3zlkh84cFjP2PGkNkSq_KBezC2NT3_ywvcIpdDonH20-nycpdhXEZOd2Pc0L97JGCAdzzjLCTWuL_tOGfhHU397N0E1KXshMiVtjXKpTGKWRw0NHNIVBjwCIlyZIDdFUlqzCrJwxZv6UCmcNWthlO-vRaFI2_D8lAXKtjsOgrjktHXHWsN1y6a7bFJ7jtpUD8omy_MA1L_QjH18cKMWmpTXzT08-DGEpeoV3rKZiianLq0GyKixNAYnCS_F-g3eEX28KXClSPHNm49nOuHhLqvSWjUN8q4UCXHSXpuQ9FduHmxPGORIeN03HtcS0EOgTOBpTs4YriibzkSB2N6e-_qvZa7YE7Mund3XN-1qqv-2_a2A3u3m67WLoCQ1VgVdk58jiMT2HLsU4nmk0uWumUS6TRmI0NzKkIUzT2H3rFnzVGFsVvl4VIoksvzhsUQ-H2T-bNC2nkwX37LAUzYESGp60OXC22Y9hznRVEcGBYJQjx7OK4jCgoh3KYZx1IiH-4_3Hm3VR-GtOocqMKM1u3httxf-cdsDlfjrVvNfhbxr_su2pp6qn8RenjTwgj8UbOU1BQwn_Qwg2-Bizk4_oA0D_etTldwCsBQ5IYfeUqNVvgYpfZ2o1-8NJASEIXpkMsfyhzwBZgmpDPLukEirq-Rw2Nrixm5CtKZBxdD3w3bI5vBM56FLvq5Mg5ATs05kVHC-YTmvfrDWz4S3odkuZx0OzyPgXb983JjW3-nzmXjxt2FLEEOmxoO0cCzX_ZPUFHK3ap8Mpkv-J0BCggPS0jS-8qU8QofKSxssc9RYcGAvwcHzhSlQFJUPnJfx_MrZHl-tSQxxOHY1wS673NBn75Dd_tdfMj7GMTdi2jIV68vcZKbpLGSYt-lV39dokPNuE167AJ3rOdmCsx1Sy_-f3PM7zuIM8Rs6i0SjNieRThtbxmRoFDOCbqf9rxIxw0VJQCybohvShZqLFF8ynR7YZ5BSZJRSab0ewV8rf-BHvbocf_MF6yveC6qHM6D20w-7ZEsDqWyX3x7HhWg4cPhgIpWogMxRy9oJhglzqVKCVHGCcuU9k_FV8oXpdrZ9gSJ6_NrAl6f1300I1v8L0RNoI-6HMAAV-iPcJkMJg0s3okSvgHuTN4Fpi2QpGQ=w1227-h860",
                            RestauranteId= 4
                        },
                        new Foto ()
                        {
                            FotosRestaurante="https://lh3.googleusercontent.com/fife/APg5EOYor25AXu4zCj5EBxsOgoQat0dQJpDWjgNCW-JrmYfyPoYOY4PJhUBINhNUbBjadFo03iUgNwpH-GKjXOGN_F_OME32lU_g02_ndJ5EQNmz8aG6p22wBUAZM5NFGfWmWQqibSirvu952t0wns6rAt6eqXty7Rii9NOM9xaW_Vt8rPWSNJIxhL2HHFyfLeRBHWSL3Ca-2Wf3RnH_9VTxSvj3DgJZPor6TfpfSoBSfWC_TmIuum8WHKuu60EyI2u7iT7v8ODKNeOVf51i__ruSreJ7CgUNQDE1ELHFHhnIl8cgAoyGx3dnkKQCCh108MWHaHi5KcpFC6Um7EHIMfe0MmlBkLZabO9a6dsoaZisKpEaEPxrRfA8VTh3jqqF7h8waOKBF-ciK4wPL8CzQux3R3HEo0hYsD0Hh_htzKz2Fx3KWwSPidaEVakFpfN_tDUoFSqzmiHCao0wNga0HAJjah8KZyk_uOVhCs1Zv3ennCAx4ED-PYMLaZ4FeKandKDtjDUpgAS946e69pr2Hn0alV4KpAXNyP1MXf2gE0G8JH8Ut8dTTuDYYi8EndhUM2vjgmin8P5tem0RmPEQvZtTK6m6JhfmS7ys2PCv-HIXS4gmwlM2iOZUdX3VrCdqKB4Wxh6j4n971-wOt2A7D5HmMcLI7I7w_lUVtxno5pQVRQxPjuvlNzpHxgoO6-nyVffZK2Vl9AdWTbur99OwNx8q6YRPbB6fGlDmlK1isLB9nUeca2wkjr_YYhWNVoMDy55Zv6M2D909Vjx-YF_aI6LOirJ4B_Y710Sd0jMB8e4szHR1d-fkPW0GyHTGZdF8f8qh1GdSm5L_aDNJWru0ezVc72ld28Nz6d6X7GpQ6Ih9wKz6p3Mt_xaeWGapwdMmcYJsySBF1GpMPBDnFsZ6QdWMuymdp-oflLC3ctRped77dwYhSsYJi_G4r7M5dqIUXl7O9rcYppHUCGHwUFswFNgsHVNveZem5bJS55U44UQ4rgfeSkTmVOYjK_fJjjCKTwBvDvULLe1KVnTRVdKYfmRfm-85VttDavMRPvkQtdnJ-65bu1QoZ5RoGZJH9evgpCzmhOvr6UuuYbFKXB00Y6bfG81sO8gSuXQCjQVEJd0XaPx-_gVGj5Fhjt5WGGf5w24yn7pUSr0grVx-qDWx4Bvrro1d5j9be_2u5vtfYJ_3KkKCQlub5B_YbzuGmIt9xQofRVAn99lbcs1_86Howd_k-ETeQ03tbhS3u4nhwb4w6HQvckMB46VYjroRr0uSecOYh3c5re-tf3ihPKsJ8ICqLYIyJTfGe_h6q7kOwEUE5ghZ_Ze9H2XoY5Lt8lY51ntvAcVSSnpeWrYaoatfzFK481Y1wd-xojX8NMAifgkuaQ5BN-cdrCynvoeZWjgQgXAScaSyxrE86vGvpKTkmqYPDCsTqmvGnmyDobO6MywaeaCz3B4QjVFoAsBIeS9JjvQmbonhBnrciWmpYlYZaLzpppBbgSK5AznowTk1B-mR7WNk5rWT-OZhXR6JQb7m9E4ka_Pog=w1227-h860",
                            RestauranteId= 5
                        },
                        new Foto ()
                        {
                            FotosRestaurante="https://lh3.googleusercontent.com/fife/APg5EObBcf2YYnWcpQ4Nibqg6UteHry8ZgnR6XcVGx0YQxioecpRT-9VTQsjLs3gom1y3ZEmS07NzPLzgw4CZYrZuP_gab6Sq78PJXcorv25eA5W7AWk7rSZcW6OjIhHV63FztYGdYjiAqDBw2FIq4aAzoKEaqykR2rWo3UNbQCH7ggvTdrFYXiyFI7zAZxab-zfriiK5Ji2YJNP3ko-9x278wAmAamk2mYZeCXJekrKSx-f1qvTi1AWYLr29MR7BLYCLIV_a8ASiJ7q67ESw7E0N9xX377CXh1nqx2X1_M903-pHmbt3JJrCm5F71PNkLe0o9VphIlx-R7yWabPvOiBxJLYn-fYkJ7U84cAL4B7k0Vr5vPb7o8-dlQNE2aRY3f59XUbij_EeqytcqmUPvNRJfiqRhmpZo4whsVo-UGR7JwoTxm9dryS_xM6IWaE97SuO0ZkR9DqimyYNw1XJPTL6Umqg5gmksAa5yK-emSdYqvyUTzieojYM3Oup5jtXwc6TCOVyNGg-WcJwViVk09vevZwqL18SnykvAJVKkLGxjsDqVrov3yvJhcRtZRmYFw9uUbSmSBjCBlPOPC1aWpY0eoCtiZBTdpVv6zX7CP90AJNRAQlvaBLJQp5B28t68gP4TC-H-F-kkO_N66gHiEka2jPBd673TChHKP_FwtoskDRlm2gzMcpc9KVvd2mDxCAY_Hw3n-h6g3rV0bwuFAzO6-sjQd5D6BDth3Rgy2Wn-pblQZQxDFgbATNBxESAPmBaUmROhUQy3IF6rsP1IP2ehXpDgoVdaJo5YT9bDv-ry9p9yvz9R-bdRmBP-R_zqQXpRwIX1RyVTBx15fU5Om3-XuSbJ7RmM_7h3ZnRZxNAHHsVPM6TXkAgkDVOO7vM4kgniqcvPjBzvRQGBkGQGxK-UTFOqQqKbp4ZYkJzSjNThDTo3GM5YMtGA7Q6tE-zgqCSI3KdF-KZDz6K_28kq530S4XuzsbxV02VzDbLpd1PC4GHDM8yT_j3EZjzJOu9kTDck7E85I3F6WcUHde-4U1rvvfxCsNRLDxhf_RAEy-N8xhTGQMT5F9uTKCnJnHrS4aFS0_f5YzkJh1nSjTIdzIr0FjJuJrSO9pziHkwr2NS5kYzeyQEMmpXv-lohHeV6vT8LFD508OEcTKGrxpwNAaNxHyxHtoRFPS_eQMRpquGFsu07PGF4tuw05fUpUl0wsw6aiDmnaLvDE5ged9x3SlLTHOMKkkNZTXCwRJTPsqIdkQxiXjIiu8u9wI7RF4vn7AiXKflBJndkSDzdAnJtNxDvzeqxbqiDPXUYnjQt3OGz_4HsjXkMM_te3feLuharCKOxmxycvuXEIq1QG4GuJkzYQ_KupXwr9r02YJSnn-zZPdjpDrHlXsHuZdaz8Y_3ZzB3CDsyUmbJvB5YwtqxQEhjUSC3VDJ7puzgvvYSmZjFlt8cP-cAZAAd90WPIduvTWvPHoWUuEr0gRSpsZkoEKT8oPNkm2DbIfTCqXTmWogBvsGs3ZA9097YYPuhqEyrhgUAiBvA=w1227-h860",
                            RestauranteId= 5
                        },
                        new Foto ()
                        {
                            FotosRestaurante="https://lh3.googleusercontent.com/fife/APg5EObchMwYDj7L8nyMmL-DKfCMV16jJp5qbwtP7gB5Sea7gp_wiMq--DvHbruxKb-Ow8VG8dLsA8Ui1U-dLb9L8bMltiy4Ru0rjmmWxYwEkML6KL7CO0k7S8JK3XTSieBBIT_r9bQ2MdsnbEJF_JjlWH8QC4SfQFh5eLcr0DPjKCmY-fv37GFvMvwC8DTYORRe3A7oC6WhCh2EMjrd3a_6s-H1r2WQcp6aiF0MikVWnEP-VumxUYCW1EadQVKaQ9MKKRviMHTUA9IiSEUx4smAEdm9iexYRRMr5LWEPy7SuIt3Ah7nJjnhiueriWmfpLMXqohzS894rtoFSyXcaUxPDDVdWWql2vQdDkGGgSl3FGfCmFKe4Sm5rKxACzjhZ1HfhtC33EF411NnlbUwwnJG1FwiAnXZezLwWXAPOvXXiES-FLY238Iw4ZpOWkwSi_6I_iRSBp55mRzQ9YbgNABE-3LJHtLLGIdwLiqwPAi6Ty69hQMmuHhMSUIcT37N_MXa3QZkYIL-r-K2EzR9ibzBBTghAjMEOd_IgKcFKJlzBZLcCXc7E7n10wKiAnkSgbVgdjntcB4ASjB4yV3GbJqV3lnW3yQl9Z3BXVaBPXGG1yux6DoNkxlOyBQnfCEk4_jFN3RhWdL4y15XytNyyvNn8-nrKsymgAL47HJJcTFOlmrEXVkZjgsqrBPvy_x8-ZLcZ47nGkyaOICJpSMEv8EoJ3VgqQrsCqOlq0qRnS3A-MBkI3Y6b5tYm4tG2nMsQGQx-0O39BUW9PI5r1gZ3ruyNkZ5c5wOVNUQxOmR0Wd2syLQvQJLbw34jmgQpKLnXMnBQ-Wk5xoQuoJ3zHq9e5XnPtGaQXt4soyf4GkQoxJEtsITFjYdNflODFaUZMSWJWsemn9WO7St9JPf9mUtnsvzYNp6Bp3xg2EoL2fxKzdiGF55-UneJDHGXCEmquE7i6iYpH94WkYQqnIvMU0DnWgdpKHYId-bfMIUQ3oBwFrV9bi4EbfJc4MV8NyJ1hcZMQh4pjh0l_TJjOIz5u8VYpTyAOUNM7eJ34en7HCiGUp63Ej4jqew4-u-zS-GNJMmwg9CfZX1LTrkMeM36TVL8AS675A_YLk3QYuyPbeTTYxfTyWEXub4_4q8loyhm5038W92EJQFjWgIuLNnTWl3er2av0jrz614_DNZZxqWbn9WNGMIant222OKVOKCYR7OkmbReOiB7jdjqMtm9Ly3xLFVIGk32t-7K4RgGXkV4PBqv-KEJZmaMy0sUbLy_1n5_HakTh6EbES69FPS7p_WohbvGDj0tBHlBuVoqhiMeM3T-8Anq7YsqJCLuzniQMFShC4TL6i-4v9iw-9RAawVC2buv2hMGH0lnWcKZ7tChjQ7tpiCPgBOHywInqpbInB166PX1T2HnJTw50SIrQg1wL_UVI0FCltWVwblc2YLShOjNruWSJ3IdNXqwjWpk8cR1q3RtrmY43_kxmRAR6k9G5wHsX7TxhG8YVphBiT-M61D9e01wSC4dUVLzg0kIwmkbBROeiagQQ=w1227-h860",
                            RestauranteId= 6
                        },
                        new Foto ()
                        {
                            FotosRestaurante="https://lh3.googleusercontent.com/fife/APg5EOZNj_-Q5XzeSOH_nSVzfOl8njICWNjSJcmbTZXJzKuyB1-g_jfkjuy3sUdeVtMhAfElHc4oY2pWFgpBlEBhbkDlZ7bc_4Bc1IZxgj4D4Ey7fA-Ht-hkTSx0d0yBA52yfmzJT2NBptCrXJk3ohBhDe6BTzLELmg3CeH7bv_eVE5MTywq-p63STOjhPnir-NpN01PfxzAnvfpJ26zmlf2j-Zfl22l6jt8tiPsVLjfnolMy-3y_0UV2Tho4uwpg6DEIBdA4oXF38nyZ24Fl17FuHwwiFvT9FFsVMc2976knMVo2dT9mqntBqytkM1AqfKWA-EolG8OX8-H0gZwsOKU3jWb7XNsgVMlygVLsFmO8ecd-zO1Gnu7qVXXwZb7NmP3j7nbvIGhFFtiaGzTaef-_sr9C_WRy6mA9zR4AcF_wj6chcZbeJ5TG8W0DXIHH4KFpo-fir-X_C-1VMp2M4GqMPtdphfwdodX0bysFCIaWurUZ_FczSZku25ZRhMpzTvLf-S3u9FYszxGmRCCmuuKROomEW6r1F1FSFJvXZZ_ZrLsnKz_q-XCU73qqZytaK_v59Hasjpn2OoaJqb0V8sr1SEdt6ryPxkbzXTE4SZSLS3ZZ2tsO5d5j1G58ScK9z8pZY1xi964edIlWYP4tq4asxgM91DJTEynrFKPsYASKn6URtYfHMD-ODziHunNMWRN_KIJeYgayqLsmszsEQitCFFVMntT49rAKYK9pIIpvsbvV0rMHFwMJfvD6jay616i8Qx8JkUtV7koc5V9G-o3tG01TajW6QggRLTgenYMvY6l9OJnMcBWpO3OKBMizA5HStd544fXkbelQLnyKLzbBSAWQCR0sddHoMef3gWcXJpNnwH2aWgn6zLHibPH7awxZQKNdPwl4Pxsi2G1RO0YOTeT-BIr2ijhcaEQLUIoledds3H4OWAGEhutLPqiMjcl2-5WtHzRCrOx2H1_zxpt61-f2Yed37FIIiWZYDVm5mBx8nuAjzM3IGD5qM9-4tIE1VSWzokZFgQwBFfome7YtpXwzqcsc7httB5KBl4uWXw-4q8uB6iZMGQ62gR6wO9IA1rxp5BuONNejLOxXXo0WGRLI1KRkUJonsshNl9gBKi6BDUaq105js8A4bGCIIZax0XO91YILPQU-DrGbz28SX2N_4-4yGhqv3qHsMttjQM7oRB6FqUCwca_Ukzitnr9WnLmJtQT8AMatdU0Gxk97CkQXcCmFK9c6O1I6zbN_-TAI-q5pqQcnv_5YZ4FAFUcWfTCxTcmhoLQYoaIzE6PrwN2DL3W_RczN0yDWyTqCztgghenuLGlqbJmh5ce3bneH7IzoNqxQyLoSPfktKnfWjUs-k7s8zafkc7zUJCq75l7S3ldHku9aiL7ViuK--CFoiuSu4615xi3ZJh0-AhN1-81Bhk6eYuFwvPdsTwEgVlcHqE5GFzvP_fa6dGl6Be3j9K40K1JyWyMBl3uspufZuBl3D8fDzTH6zDKtb8_HsVw-GQ6_hzFxhrAULcldXx0CfrSUw=w1227-h860",
                            RestauranteId= 6
                        }
                    });
                    context.SaveChanges();
                }
                //Funcionamentos
                if (!context.Funcionamentos.Any())
                {
                    context.Funcionamentos.AddRange(new List<Funcionamento>()
                    { 
                        //restaurante 1//
                        new Funcionamento ()
                        {
                            HorarioInicio= "Fechado",
                            HorarioFim= "-",
                            DiaDaSemana="Segunda-Feira",
                            RestauranteId= 1
                        },
                        new Funcionamento ()

                        {
                            HorarioInicio="11:00",
                            HorarioFim="23:00",
                            DiaDaSemana="Terça-Feira",
                            RestauranteId= 1
                        },
                       
                        new Funcionamento ()
                        {
                            HorarioInicio="11:00",
                            HorarioFim="23:00",
                            DiaDaSemana="Quarta-Feira",
                            RestauranteId= 1
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="11:00",
                            HorarioFim="23:00",
                            DiaDaSemana="Quinta-Feira",
                            RestauranteId= 1
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="11:00",
                            HorarioFim="23:00",
                            DiaDaSemana="Sexta-Feira",
                            RestauranteId= 1
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="11:00",
                            HorarioFim="23:00",
                            DiaDaSemana="Sábado",
                            RestauranteId= 1
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="11:00",
                            HorarioFim="23:00",
                            DiaDaSemana="Domingo",
                            RestauranteId= 1
                        },
                        //restaurante 2//
                        new Funcionamento ()
                        {
                            HorarioInicio= "Fechado",
                            HorarioFim= "-",
                            DiaDaSemana="Segunda-Feira",
                            RestauranteId= 2
                        },
                        new Funcionamento ()

                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Terça-Feira",
                            RestauranteId= 2
                        },

                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Quarta-Feira",
                            RestauranteId= 2
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Quinta-Feira",
                            RestauranteId= 2
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Sexta-Feira",
                            RestauranteId= 2
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Sábado",
                            RestauranteId= 2
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Domingo",
                            RestauranteId= 2
                        },

                        //restaurante 3//
                        new Funcionamento ()
                        {
                            HorarioInicio= "Fechado",
                            HorarioFim= "-",
                            DiaDaSemana="Segunda-Feira",
                            RestauranteId= 3
                        },
                        new Funcionamento ()

                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Terça-Feira",
                            RestauranteId= 3
                        },

                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Quarta-Feira",
                            RestauranteId= 3
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Quinta-Feira",
                            RestauranteId= 3
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Sexta-Feira",
                            RestauranteId= 3
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Sábado",
                            RestauranteId= 3
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="22:00",
                            DiaDaSemana="Domingo",
                            RestauranteId= 3
                        },

                         //restaurante 4//
                        new Funcionamento ()
                        {
                            HorarioInicio= "Fechado",
                            HorarioFim= "-",
                            DiaDaSemana="Segunda-Feira",
                            RestauranteId= 4
                        },
                        new Funcionamento ()

                        {
                            HorarioInicio="12:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Terça-Feira",
                            RestauranteId= 4
                        },

                        new Funcionamento ()
                        {
                            HorarioInicio="12:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Quarta-Feira",
                            RestauranteId= 4
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="12:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Quinta-Feira",
                            RestauranteId= 4
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="12:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Sexta-Feira",
                            RestauranteId= 4
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="12:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Sábado",
                            RestauranteId= 4
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="12:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Domingo",
                            RestauranteId= 4
                        },

                        //restaurante 5//
                        new Funcionamento ()
                        {
                            HorarioInicio= "Fechado",
                            HorarioFim= "-",
                            DiaDaSemana="Segunda-Feira",
                            RestauranteId= 5
                        },
                        new Funcionamento ()

                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Terça-Feira",
                            RestauranteId= 5
                        },

                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Quarta-Feira",
                            RestauranteId= 5
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Quinta-Feira",
                            RestauranteId= 5
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Sexta-Feira",
                            RestauranteId= 5
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Sábado",
                            RestauranteId= 5
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Domingo",
                            RestauranteId= 5
                        },

                        //restaurante 6//
                        new Funcionamento ()
                        {
                            HorarioInicio= "Fechado",
                            HorarioFim= "-",
                            DiaDaSemana="Segunda-Feira",
                            RestauranteId= 6
                        },
                        new Funcionamento ()

                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Terça-Feira",
                            RestauranteId= 6
                        },

                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Quarta-Feira",
                            RestauranteId= 6
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Quinta-Feira",
                            RestauranteId= 6
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Sexta-Feira",
                            RestauranteId= 6
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Sábado",
                            RestauranteId= 6
                        },
                        new Funcionamento ()
                        {
                            HorarioInicio="10:00",
                            HorarioFim="24:00",
                            DiaDaSemana="Domingo",
                            RestauranteId= 6
                        }
                    });
                    context.SaveChanges();
                }
                //Mesas
                if (!context.Mesas.Any())
                {
                    context.Mesas.AddRange(new List<Mesa>()
                    {
                        new Mesa ()
                        {
                            QuantidadeMesa= 10,
                            TamanhoMesa= 4,
                            RestauranteId= 1
                        },
                        new Mesa ()
                        {
                            QuantidadeMesa= 10,
                            TamanhoMesa= 6,
                            RestauranteId= 1
                        },
                        new Mesa ()
                        {
                            QuantidadeMesa= 10,
                            TamanhoMesa= 8,
                            RestauranteId= 1
                        },
                        new Mesa ()
                        {
                            QuantidadeMesa= 10,
                            TamanhoMesa= 7,
                            RestauranteId= 1
                        },
                        new Mesa ()
                        {
                            QuantidadeMesa= 10,
                            TamanhoMesa= 5,
                            RestauranteId= 1
                        },
                        new Mesa ()
                        {
                            QuantidadeMesa= 15,
                            TamanhoMesa= 8,
                            RestauranteId= 2
                        },
                        new Mesa ()
                        {
                            QuantidadeMesa= 20,
                            TamanhoMesa= 4,
                            RestauranteId= 3
                        },
                        new Mesa ()
                        {
                            QuantidadeMesa= 18,
                            TamanhoMesa= 6,
                            RestauranteId= 4
                        },
                        new Mesa ()
                        {
                            QuantidadeMesa= 30,
                            TamanhoMesa= 4,
                            RestauranteId= 5
                        },
                        new Mesa ()
                        {
                            QuantidadeMesa= 18,
                            TamanhoMesa= 4,
                            RestauranteId= 6
                        }
                    });
                    context.SaveChanges();
                }
                //Categorias
                if (!context.Categorias.Any())
                {
                    context.Categorias.AddRange(new List<Categoria>()
                    {
                       new Categoria ()
                       {
                           Nome= "Carnes",
                           Descricao= "Lorem",
                           Imagem="https://lh3.googleusercontent.com/fife/APg5EObvKcl7EvvDXDbLLtvpqhW6m-j_Hj7L94ZXlmTCeWTSW6pBdx7uMXYQZmxWrl-iclJy2MOj8n5yQB9p6gCC1QIT50f_1_OIq_H0jOmmIDhqktWCynwsnMdinQZIaQQBDm1NjG6bpiYsFVp80w02RLERUyI2LKuimqMASI0h1LwPLW2Kmtfd3OmhZHGDn2pJeSDDupsrh8o15V03mIdmH_xNBNFKjsm22GuS2UQATK-Ps_Nxzhzmb1_exkEnyEjrQ0fJ2TD-HcrLXdgx5KS3zd6ZtAQZYQBx9Oc21MXzCVUvfDdpSuTez1sH-TW3ETC9KrR4yj7qE7kr15iMTLUYniZVLvMjdVw9MHg91vwrCivCimqIvRt2EHYQV_f-1a7-rKIgW_CcvigMrxe7kl0zugJdLVIHKQqwu3I-6i8D_B423uebVtBTjQ9JZTlMBp9vWKEp0hG6QCWa8XM31uG5U6rqxhVm68hp-4vxyQQzdW-2HS-QAmpMC3cEXjnYPcdaqkoUp7l5wDZsNCJUpI5rFcSBG0LtElsTp6B9HADW2B1H5D65vaCxQOpkgrxFRHkflv1uvRiVBkjzdK-nbX5nrYSIr3f7tDDGY-AMrBNWoAO-K9mm84cC6HSvCbQ3pYISB-8fbBW6KT5viOCyc2xoNLSYby_zKnUdxfVcOwFIGBgbjaQCahb83KNiTGO2O2H20oHVUCeMY7EDRUZ8qg-Fe8j3vCX0Cf8DQFhW5_P6b21_mQP5aIrIfvaCUiPJrJ3N-dhpgNVDjxVtjHCJ0d3ZSIiMe-LJw5hOt37RCnhpk-Ya-jm56QPqhL6U7q4GBooTUqDJOzoHgCt8TuHap7WbpaO5uoVQdpmEqx30pwX7kpTqM_3mJVd7UN8vlYAIw2eYxqJ8ndSBdDspcV77QLFaTSgAM323ZJAGJz5dTorXaKD_yr4ktimTa25qTHfoLDfc7luckXEMjZw5r_JQPiTeWSZCzW_kEW1ehTMacymoE9Qc5QFX8o0ZP9hqCRqTs3r84YfExByazooX23L5jaZvLyZjIBTMnY5pQg9XdoXdXSxCMr41suqcRmrYmy5apU77ZCv7-baPpVb8SsjHOBCQp0l-ePMFfoPGjQDI9QJOV0rIt0K1natOo9NEj8ZWyd0ov_DhUQi3G0uwyzuwiMvOmoompOelM2QT88AUQbN8x1KNZiKZZqWFQRmHZd50ZWlOoEIQVdcsWi-Yu4u22kORK7Iy1v54QjbjHemXhp7jGadnfNrSRnSq3ayyijR1c-PdP3hNVLUlI_qOdlcg21uIz-kAHBO0G-j1RUYxChaeS2uY9u7ZJIETItsCgGZl9nUaJIESZ0_dcc81MYIYQVxegsREZHuqG6-2hPLwWdayDic1HixzSf1hhGfPAtAhQPM5k_o7bA4BE6KZ6eOIw9tGIyqtyvj49EKDSwaTXeJsfQezyhVRikan2kGiqhKYC2xvSoPq_c3W3J08avXP02zq1kwzgyKOKiQvvzfftrHAGkCXwuikwFHkTAHGe2LmSR5zqlfy2w=w1227-h860",
                           RestauranteId= 6
                       },
                       new Categoria ()
                       {
                           Nome= "Frango",
                           Descricao= "Lorem",
                           Imagem="https://lh3.googleusercontent.com/fife/APg5EOZ0DdqKgYMkGA_H5IMhtNTlDQ4FZC9a96Kd-hn2AfBpPq0bwQY-8M8jErmZQRDE1A29vaHgOipjamDjFKd1KY74Nk-ZazhBwXfbPB3Sjy2CPkQrKpX5JeuljdBMkdewaMtwuLpElOOrm7XJXzBYBnohXsVk38PJXYKjANbPkTA6SzL6hPqgx_ZeWJkNQo86au0MocM04PHPSRm5Yioc-erhH0mwa_K9_q4dl_PJSVCN-Recdt2rP8h2lIScy_0rTW7GAv24J6KHqb41n4rDuYDMi8Y7FFOT4VnS8XfJGnbTYWdimkrugIM2tkI0w8HlungFdk6FFE-bloJxwz6MU4xHmDAtoCFaP97OXoIbV1PDvo1HzO2d-XmcIx3QA11maMuimQh6B4S0XVryphcZaExhM61zXgSGIl0DNWLwjjKe9DxMPA2cYF7Uyxc49B10bii7uOxY5lLtOyCLJM9g3IGp6wgNYPgbu7G_4BekNqUFADVVYb-O2id1HmFFhLZyHkD3rtWuaC7gF88bQQtNV33I2yxOZ2Jh-r-IDVQu3oYMYZtgQ7vMh4CU99GyoxnWGdRjJhaUhHOwCtXEMl_o5aU5xXB-9KKNFqys0x646AbpNbCfrkiDYdbIQQIQppz-U6PzDqTin7Z588lqOfJU8VKcPwOV3xWRkr_n5gx5RR2Cin5SiWTp3Y5hAxTvBzzZMTDWbZhFYRoGdGB7UGeiOInCbcuUzt9jtRV3fL0IxyZ7HJC4AHAzl2ob4bpdz9LgorUptcnnJYRFAtBvC2Fj9JbPPQdko5GqV7jLtyoVhFFGYPqxmcW9XxOSZDUhr5VUWgobRL5wsUx7HApik9w3CNqwVS0oWxPWQXJz6BdQYrL8ecfdnDw2v4dI1kuHb0n_rSadtEPnckW1XO6TwBwUEsuS2X-dA_R5ETeEOvf8-KVHxxycj_V1O_YnySxaBKAvD-QZS3_PrrQF6irkZ1V7Ta_f9VolCkhHu1cO_imIfohgipIMDhONfLFBrldtzzhPmGjsg7-BNTgjyoryHw-cm2qvcNC950zT157WuyD9AYyjkpP8V2Aq3IKa87wvGXuGk4EUv7QQweGB3EKZQvTCSMC5ke6_6vly98f6PUwAu0ZVm7RCDMZDFVN3Bc8OvivGD-hOqG3VpT353Wa5FaDOHdgczIQqxMq4IyVJilD_Z9E2ocpHOocKRsBWeWbrPdyOWHYTERORLT9rBCu3UU2bxl3zhS2UaEZgMmL1gZ4ujM8bSP1QsNn8ddY80kJ0_dJsmxBcC50Wt9tin6N9nn9992t_PUCZbRfewvne4fnloQwhpyWEYvvTzTkUcAqddaR-MwLixKlFqRuv3nQ5d4lJVA8AkHVe9oBe050z42k8Kf9zCWsBi3c_FcBsppKn1xsgpf-66zbad112H0XstlszAJnIU9zA6_ddtbN3de34It-VEpNd6qN2xumyvsSD1qrXakTlfYDF_DWLZDnI7fpnDdRbkUCxayJ9EXrqsGHNDfUh2pJsCCbeRfv8cj4pa7dHCJ_XAA=w1227-h860",
                           RestauranteId= 6
                       }
                       new Categoria ()
                       {
                           Nome= "Churros",
                           Descricao= "Lorem",
                           Imagem="https://lh3.googleusercontent.com/fife/APg5EOb3XRYXLXh3in5x7F6SYXlG3Bw3TnWRMw7uMTAU1cgWXBdmmUlhnyZppypYj9rnePcydB9-CEdBazG4xN_emDyTR5HYsqo3LumEMjuNIX7dj39P0BcL5swUbL5_CnOSyRNzNzn4cxH_-js6WJ_7hf5wlbxuRFN3IepYVLlc9rrEUE5DrO0DY137K8a4PebZFvl0PDoNuYNyC-6TWJAcPMcTmjUnUKO-LN74L4MxX16G0fYbMhAPVK6KeU8whTare2hyyvSXsFg_Pu5JFY7oA0u7GMENH0nFhqhB0ytT-DusTS_mFGy03LuCbGfH_nZhElaRgBMSLVAmCaSOr1JG2t1FKhKEXtOx-4sGVdZgrmDGO4IuN77IEBKe-_56ncdJzkB991g98XUk8Qym8j4qUe2KZH5lhZa_felj4O2thB87JaR-7LQj2us7vSUGqcnS0f9zP7eugp-eVpH3uWzO6158yNQ4amkMLb5yny212GAcSVUKfC84Nf7NKa1SXrylV7Smh1uqetw3ZZ4XPqtj2rWggniK5AMnQxCRYOp93bPJqc3xVo10-vVNaOB3BqXnB15iDS6KsRAx9whJcQuzm3Vu4lpnH8ponOl-MYfJBG7wrSBMiDWdA4LsnMCEt0yIDleM_5W3qUVa6BcmmBiDxxE4rRi8hn31GjF51tQ7_qdS8pas2XB2pyTrDTSV88GIKS2W-8AjETL4PofKCm1QLEoSJKbVffzOJ7zx1X_RFvjs0OurDd2gPQEd9peQ0tGv0YoJKwEaf0C_x-673hBIlN15myC7m-Lx-ZuWy4CiXRhw6jMOxfIsV1BcA4suqOpsxs-Qv7zHv1zkPbDuj8Jv9YXyXQ4c_CwDvTzcqtj1QuFIioW_BlUfzwPTt8D1KI6ptkj73GT0zRPGjES0a9-4B5-4T18vtk098O9NUsyivu0pRP-oxRlBMFmFQTSFY0yYNmTgDzAWCgdGLiHlvItpCF5CArP5NjJOWEHbCgAa4LGV5_7m-JMNB0oRUWnAqZesk6OLzT3exHIqcOcKMxACXkCF0-W4pRw4zTEK6MUWzJZomWyweqXgGFTcFb_MjZ2MFpeJRiTI7Cy0OvoQS4DFMMCnaezV4OOV7zPsozibvCxCzq5MlL65f9TKP2YaptopBLqlymB0VRCB_tlqtvM_VfFAfeUsspeYzB7tNjZBRW8DchAhvQT3pveSKoRh-op9uqPW73HpZBEtgcwxfH8WHLZ9m6ljkc6A1T66yvD6W6lxDZzpPgiqe2KhjfAnrNOASd90Aylv8981U1hxbS0H_eUVF-D7e7ZqzEm5498tweBbN2A8oPHLUeRDtG6uOZoccJxZzCo4ADBH-_8IfNpgLzxKbdgRFSCwam025TZmeZpi3Woq4JUxReD6UkPtJY5d4NIgYo7v7wvVzuxcGGZ7b4FZ2Brt6rSCVO7F5vYz2tHbBjuVPi2P3EV6d7tzn_43D7D8c9Z9Brstep9ngiVhISZrGvBNQzPemjeshwy-_dkaxk96jOj_82VVEVwHYryRrvZJyQ=w1227-h860",
                           RestauranteId= 1
                       },
                       new Categoria ()
                       {
                           Nome= "Bebidas Quentes",
                           Descricao= "Lorem",
                           Imagem="https://lh3.googleusercontent.com/fife/APg5EOYgB7OnkARS56uuHU0W_Fnvd4evysI_bX4Dw-bYfOL-cvfMbMLuyDc9S7174_o5PflpE3egcfYjlwBeSzQNfGyaL_xccerhEIEdaEM9veDusSWkRbEQ3QbrrXcIgmDuZsSd6VjWdB3ajfNbzeFkXdhPuhq32uGSMci4CNMa_XXCFWGXfumkDqJqN5F_WJ0buUdlu16NUR-nG1ot1MZ2KegyWKLyTnhJU8SoGGepQdlABClkHgsrXU99RYY9UccLw_9yJyRo8C2kTb3ZcCcWmQ9wjlDRHtPCLvKiUH3ZzPxzLjqix7BsdrvB9C5DZifRu3QbUSR2baTIREiUZHBIyNU3_4tbf0xnF2OlW_RWJdtDix5DKGXDL2di-zC3zDOHCi294mQry7XTa5vv_v0qnDpfXuTh0UQTg3CyyuEYThzVu3wPtkRXwV_2MH4j5nRVGzgog2j4ZzbhPwJQIYrsrOVLVEUk19ocwNennv7JRdmcX-6EQgQk1x0vzbwwE-1-piyk99RWmiLtYTfvkYIwx0RxD18Ju6GQFP0niPmAQMBAUwZ71Qf19API2aMu765JVSWb2LfW12_oLT6K8UqEI7rbBPkD27SDV8EfkSQCc3sCBfasOzRKubsTMEnuCzIJusONFwQ_oyEDgNM_siHC6-93-bfPoopxasd0o0TypXiUZLq_sQDn_zc9z1Jq2CB6gSxycI1ZsIlhlDSFPDr0JAfz7voj1vi52ZzGc3t5bJrA5ADggv0gAQAwiQ3xJBmFTrP3Yl4TD6IRMubA9qYMGNHVoiyO1FvxopWeyI2cWWrWpu3Gjt6KfulkuRgLYRVBkG5jr5TpKwmEfOk3m8tQhu_tlWJDVFQRNpaUD-BYX-HWj8T9Yyi_ynT31tj6chqhzmiN9Y1iTaO4KpILvAjv5y5eGjA3ueGaSoZNer8FZVjZE2V_24VabMV2x5iy2qj9TLVlDr9WEiBNw9r9fhLCycY8Qgd2WL5uMvyIv6js3anSN5E4lv4VCMiHfVuF93KimpmJPcBFl8ouIvcWSKwxU72g0ZHhBSv-lrtJHEcPJqG0Nq0ytdJD7Vb9BzAPqUDvIosWauNXbN9vofCJaILYEcQU6t6Rxk_H7IQ82yPKZGc2tWo4iEEZZTUL5-LhueofRMk6AEPpgG4hgrKR5RuYdhSmHD6eqjfIFltW6na1knjNLJuOuBc9mTcKe1VALmj8XeNOg0-S0StOzalErk2KrMiV_trgeEIiqSefL96gKt0Vp0b9Qm_7v8eZHGzivPm2khSb9QDQLoieyaMwuuKo0GBBIevs0rEHw6Chv1al8fstCtoE8T8rAade6bHLhppFuyfLEIZwDISp3XPmnjGvnU0MKxmzIOuqaFbXSUXBxmHXkoPi13_J63rbYWYv-Rli__7ybbqv3--Pu_OhBpxErA7XwkpZZD8w9QIZjmachIxxdpsQJLzpeZLWUAI6SmLnNFv16mOe5VG0XsOjx_COORHHuTRHA0XIzro15xdlt4w3-yEf2DoMfVCSTTtOd-3wCvG0fw=w1227-h860",
                           RestauranteId= 2
                       },
                       new Categoria ()
                       {
                           Nome= "Salgados",
                           Descricao= "Lorem",
                           Imagem="https://lh3.googleusercontent.com/fife/APg5EObwfDyvwMEHf-9H7GsDTCViM2cHR6OybXPt6WC4SnFmlW9DGtHDThEfgOkbEqW_tClBZ7BSs7HYDacOA44PeaFpznRcmdoicc7qo7ns9Hng52d2WIbJpsAHSYm68CPWajHJablWvuEkCTfyBSlE8dw2e14NTm9rwPUYNno4g0rz3nS-KtkzKY6inCDI4Quw-S8gWLz03NyOukUkNj_iFcptkp2vfqTM6S5AZy_qLz7b8-CjCIfZZ38QlFh5aGNf6rNxAyUJCLfv5qohfqZFLJui85AuEMJwhEr3lOQ-KRVJy1IabRbQqIsoyK3WodZsuytf0qCkHbMZjnnaa95Ne1n7Rj3_a7AYga5tfFOtp1EWn8GQswgqV4QJpPpj2syWdXXC7P8CtLj9QpCmcLUnYQfGclhE9D4HQwicvU-fHp-mrsy71tWH-vbSAO1HFHVOU9fLVt0IqJ6Q-J9YMZJGz50H1qTtlXR6salQyfTRGi8gENuIZm4iNSA41jmuaMNLTx5zP7HoHVLk__dfaTs-qPekT2XNngqRvKN7dxU6oc3I5pM9dlhWSS5vdXikeUTCZbtTOBvBIsgG9RvXCbB_zTNokiQPM1lHWlkOOyJJLIoGb-BM7oBog95eYuupvI-gYfWGN4dolethOLWlR6Olt8voCJ8sE69-Q42a3Qxe59-MEb95-fm6VJvST66MyNP3JT8Uzbl_JZEp9SDLyGF0B0qAoD2tke0B4Q-ym166AHsaMz_NyCz06KlNReOLQrzqHuny8EE5JD7yhRDDPVPX3IsfZzvWwWPXyY6dnzFxT2raipyX-9hkd226xy-bd6GYRmOSIvvI3VCGQRCVrgV3H2L2fbdDrwCO4y1MPoTG2kXVd9h-t-67qUkiHaQs4ypeSfNSKThZokX5xhBA0pRv89LdqB4LWxpFv30Gf1BKAIvQhmE9wjoRMcTigOhHClegR_f59qeWWpJr4T7m-QrNe2-dvxz9Ipst0CxLiiwZ-nldLH7rGjAJXsWCtxq0hxZpzBESQ637g6z48ZvCNuSgo3CoZjUNUTbvvSCXB10IhIGVa3x5VCXeWCd7oEsxzyY_eL6IY2z3AlxAlrwiio3ZLDKfXClflEh_INGclTRCH6KSPXY6XSyq-Nmu_TCMxKeb-vcJol30Ry4FpXIaRq1kztfyQeulehSoyj-vz8o8D0nInJWTGy6xmwCUD9mWTDEqUTYV7ewiIhbFHfJOJ8u3t8cVHv57mxWmB_15QiiqKdv-BEQarKlu7LvfkIC3V8EAg3I1M_o3whH5hQft06ZYJHRwAVrIuG_JqarpoJ-UZAa_hK70NFkBrmWU_gUNVl8uBbGjSvKY3NqZqi3ajFcgBvJem9rY7jl9ayTQTCtipV7i7enTuOUecx-eSYu5o6paKdZZjMBqMbfT0V7rsyN7uJY0OL-MfmsLxWCOIa5JWyz7toYHgC3KXewRQvR6Bl8Os3TqZHtpzqsBBJHnWfxD0gJc-Bs5gw18WY0iNEbbuSMBZ-2P1UBiCjs2F2JThSUZvi5Xuw=w1227-h860",
                           RestauranteId= 2
                       },
                       new Categoria ()
                       {
                           Nome= "Saladas",
                           Descricao= "Lorem",
                           Imagem="https://lh3.googleusercontent.com/fife/APg5EOb7DZiBZhbIm1VCJY6bUasLnbtTpB--65P6AAzdZRZBV-1f_cZuhnQp40SZqPaBwnaTxz_Trm5YYMTHzh7aqhv0IISDA0MqpnT4XI4bw9447Uy-pntk9kS-zABhiQ_DIO63UjoS7c3ft50KWglVeGw5kuvi7bpPVKEd9IxXkM6YgXWioswzuxkZdsqJuZwkGWWk7RQgXJ4WL4UHTjZXSY4sEtWX_EkFoRXWK1NptEYp50IgdEYWauUU9nYOhxCzXlLLctMJroIJkaqX1KWXb8jBSzadij3gTKRnrydRq9GhIi_bx-u5ghipAT9oGu13skUXj7HKgYQOMHE4TK7Ryyq9X0FLHzjjBba5OKh1oEiWXP88dtua2SNABAbLO0R1iGL7GqVCfnN3kNqb9N2UNJMAeBuTSR_Ig619W1CVl7Kl6ws4qnVJeDckPKc0xEOGXblNwMN_JJ_9f171FiH9TQYs8ki1PpGa9imefPvM1W5G32dKKOHTy5jRYsrucmJIezW7YK-ZfbopSLBUdAKjLhOqCFf3H2ZflU5KVPJw2y1BqhacoCIXDjx-U2Xp4Bgbdd6u9J1NGiIPHbsq1Wwyl83czPv48oBIpWXhX1KW7icrPutznBEUCbyx6nCXhXpxySO3HmJsHftQG6Nbg7Gt9bIJzKoPhOhcY_2_fzZztBe97xdqQPG5TvTvk6dzHhrTVNRFHZf93axhFVwpEj8TzdE3wsWF-OCYT2HiRxT8TLauLEsOwKNo9hgEvexJ_HgDtz-vkQPoHHPrOF3G-MgNXOsrAzhPYd3xANcZkhysqJOKCtw3oII32YJJFIvNN1mESPvCoHhNP50ooYCWxE_AH-hm4Hu4LoJAwHxvApQuSpRqsh8eDBieZjBC_dhqYcKJrB7FJQcpuMABsn1r8CLXx8AAS-vPgIvQSaJGeKBfwhu5oI-kNkXJOs_DiiJfvwj7RrAR-OQU-eB8INEavBTvMAKNnoNbju88j_CJj0-jB3umkCe0RxUlNoeh_oqjlSj0t7uFMyP66KGBSb0RbHSXgzzht6iNwiv0dRIeBcms9ioFlCGl-1I0yaLrJwlQ_pANNJdLWXH-HW0DOKPMjIid2ze4-e1_ihc0b5FTid6bfOZ7JBi5h1FbdtoN-8VSH4QIrOdQbQ0aZ2VysDowZmRhaecf1mcAiAhmKw9oE-OImm-ljqT751pWeADmqqPvXtRX4-dMDejmuDi-gT9sR__5bEv-MoI3rQQw3IZZxHvGHMix_mTqAMkJPC3a00m-N74W63ylp-cuOpkcepAcmWRc2M3bQxumCQzu81RvH875yd9nZbeHiRYgylxUmSVWcetM6P4gh1Hr3BOdc8JtfAQgy5M3GD63TYym8yqxQyAN_MxHW-WYwHG2K4xCwLhdtIWPXgW0-wZumf6dL_fpOwFyLTSlx845l_roOWRmWFBldy107aDrQoVH6Hho5u0bP0L0kLXx5ym4OnWdKQHEMhF8zUQfJFpkdVDOjn1oGuIatby8OAMey9lvGd_po43bKpQCVQ67fw=w1227-h860",
                           RestauranteId= 3
                       },
                       new Categoria ()
                       {
                           Nome= "Porco",
                           Descricao= "Lorem",
                           Imagem="https://lh3.googleusercontent.com/fife/APg5EObOBL7dQDyj9QXGciv6Oe0g4RLDStSuJaeiYlEBUsXuRIyLW8JsLDzj18qDfgowuBZNVLjxR_EFs9pGeHThu-n2WVZO1pKSWc8WT7MJ6AnA4z2nrEFED0jamflOVPjh1OQRLiIzBYosIdZbaHapNLaxcRbmCmMEqejiY40Dl9tRIBBcT7gIgbXLan7OCVJiKJpkn_EFpWPL8v6FHYEqpmeBdiCOkS8HqJOWtEa29mBlWFjg7oOM_krlSBb2_00-3r58tOIoD-YpIC876DCFWMcv9l3zzwNpAjsZ7B72GPHZHrGfhh3RxYZvBqY3nUqvkG5ADb9tL6i895ZB_PgX7iJ63xCD7PIsMYtK5KcPfnbUitPiCCrpZvE--zZk_lobX8y4PcGyR5r3bcixQvaXpC9idgu3W5f10WeCvwt_KDGh2Kh6-KEmuGxU9bzgGx0zs6QKtAdlSPM5Ce0wPTlZJydio5YHZBDJ0SRLbZCyE8eIQ8roSDbj2JqttvkCOUNJF2Mgqm0s9gkJdy24ggpQPX3QTdU0aUMDGlHngyseQuv_y-NJWgqbRKhLGmad418I0eBUuxiD1SCUNQGOendOOvY9kCTARdjWe7e5kwYiYKTECAajYwTXrBCkS_Oy2wsz5lgZ9nA08raZ0sF1eWAZPeH4DjRkyFOQsC9L1s2hfBXb4Wuqm54nyDS48_i-DwkJATjmCTWE9nJK2sKagBARcemxXil3XCydfKpa9dUMLqa-SFQFdzQwSyjZ81KF9JkD2bD0RcO0rRoWUTs_xOX5nD-VFtR4xd-2KcU6qEJ8ZWdoP2Am1MK14VPttVxXgUjOaynRAMVfwpFOAg19wxMkaodaSI_eOKhcCHXigSLEw2F27zFfzRbxg6meI4coDDvfdhrKJoed2bCslFGW4YvTApD8pWWe11S2XLiNUa_ur96J7qVQ20b6NkurRZ0Rk01J2cGKBrzJ-ONG54MB37N0U2o89EMIr9M7s35AcRTH6x8_nY1P3gW6EndK7Tcvi7kKPlKbYq1S-p-W_szIBj793mpeNTs5cTHUg4uhCLwUAfFB0eWdmkaJB_kEkLobHWb-gxElS_FA_LCIgwuXYQ-m8sw-r9D5oHQ2XR1cVxA0CBmoEQbrDvLAxEQtFgIySVTGrnXXkaH63Cao0_CgHTX5JvM4Gp71H3A1EMDAwY7QlVHICHm204MefIyBji0ZpjEvOL3cD_CxYg4vsm5u4mnAgnGSdii4_TgqJPj-ZvbIxTVlha8MPkKH7KalwkiIXDgSZGAK1uDxMuRJb7yx3gdtGe9i7VdY4QHV4iITYJtxH-ulXWl872HW1PV9LZBlPaMH64gEZi0s917Ue37NG8_jtn3mOH6qlDz_tXmzvW2EhpFcT7-aTuetGzb8EQFR2IfYpKb4vNiJtvZ-bjiT6G3DokfzYU6N0sGQdds2Ocw0mF7rh0NT5JWSqm_B1eiJUNfjB7KaxrvnfqOA92oxR7flMN0FMOCOaJPOXb_yZFdRBQoyuI5LAEZxLIgI1bG7g3CBIz0MBg=w1227-h860",
                           RestauranteId= 4
                       },
                       new Categoria ()
                       {
                           Nome= "Frutos do Mar",
                           Descricao= "Lorem",
                           Imagem="https://lh3.googleusercontent.com/fife/APg5EOa5-6F0xl0AeyM5rYlGiKzPa4vtGT0D0rjvdzNM8yu1L4Aztlk4aKfxjcC1MdvJF_CJysDBVT5iVv3MqlEWDiqBl9IVrc5CVJClum8OqyBog_HlFnL3gkRz0M4PvEVXpqJKcKq-HWeX4ToF0PM4YgrGzQCjV_gybW8jX8vAPkO2UL2z77Em9okCoMjV711jCiuook66oYx4vZTJ837TFBpT4OvnOH8P74IsyqeAppl2PHuPQBFTtqw6KP9btbgqc9PrdCdc_-ySRhIrR4ZQ8KC_WzJ8P2gcx72G9BM6mSeO2KtOCHUEcwjKHZJmV6S8ThLojL2aLM36zCj3x1FgN5lE5lV1j9pfOh4yKPNMQiGLAfbFAnwjYd6tEkl0gPD4nMzbgqFbFtt55ZPszICs2cP0Wa2TokeFbGqsBz4hkZc8RYUeOpiqw9Uh04FLGGbZlMwhWJvFwerUBGh8IfTznfrstGD2gbxD9pq8NWG9IBdJon2gInrpEtWkOebFGBQ127qZXgd9UicRj8LTxNaTi-vwR9x8HBHN0QvgZvmmNwS-dhxoL3wPQlICWHthz4ZhBYjMX3re__ga1iMN9c5yvCyzveQeKuFaxbkTWJfuIU8oTfzGmhoJPpBwhbWXAI3VpjOwAx7oF5huqwzBVl_bktTsIQJkOTvHuc2C077rj3vwsffSRnLVAoNuvqGdvuKa4hQghztA43TWm_jwRPxFPXxBEHO_B5chH0PSWkszng4an4koarJBs9GBqONJG-oNlYpOE1-8A9bYyznlsdmRZrpbO4UsICJN6PdZLL3kepAmpcufgfTLVEMMIherezw0nFDrcvwOZI7soVLFEnS4N7dkZ0FIwoxEP03W1eK7CdVQBTlcglbUSuUA6JCBO1HarJrxYoYAHfnKhP0Ku6H8hJ1VyM5vSrZwZm8cqF2rxC2l6fuxOZINj9Y0zlqFMs_IVbwllq5n-i4a4ixA-GqR5c1C3RB6yR2_A0H17zJAoNTypvLMxIEgHpuxkffTCdCG2QlYnumc06p590z3wej25PpTihYx7NBphrtHqQhaM6kLjuEvViB8_TzY4OP38qVWW2YXrxiJBcXwTjKtd5qnroPPMekZKpjNYndxpR5xsXgu2cvgYCrSJ9_SgJvdSdXkYKNJQ4CL_p_5EqKxLp7AjQTyGRw0UUOgGFlI042j9Y4MZMgOC2m4GlLli5Pu2_I71TXePyfb9OotvsAFOQ1Wy56vNaNg12LlRhML7OYbQjL5k0iVHkXmqJqeo-idVsL0IzKT-hHFlz0udAGmbSrcgQfU-Hgfmb-TqGS7MUjKPiIXUw7mxpplT1fdGsKuHhTuUaJaliTmYuoRyBaebAssSgWX00trNf6oBnhrIpd4Vj3F7KbGOdTHASb53uaO0DJaaoKoYeTGN0r0vDFPD_a9LLGQabgeyemp5GN3ZH3L2FhGygyZ9NOZAQkcNbwloRfQkcnTAwiijRVcoTzmnuNkNtLsxUfQTirUIx479WDtGetX7xGt9DRBIomaKANJnR2tmzeQkQ=w1227-h860",
                           RestauranteId= 5
                       },

                    });
                    context.SaveChanges();
                }
                //Produtos
                if (!context.Produtos.Any())
                {
                    context.Produtos.AddRange(new List<Produto>()
                    {
                        new Produto ()
                        {
                            NomeProduto="Filé ao Molho Madeira",
                            Descricao="Arroz branco, filé mignon de 120g, molho madeira a base de vinho madeira e fritas",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOYiQHKBEzwqnTv3ycqwClhHng6G1p7HkxGyqAC9bp4nw6s42NkvU8QaTXwamg5Z2bDcydkQhsW1kaHW3-l5YDUBSiJxmMcUrq1Cmx8DxAvLJpyDlajpqV9wcVxX_q3ihPTW9HoEDhG19SAMwJ8wUvwCuwzPknz-U7TEIuC_P9aNlhBGuTfwqrDafbh2ZuHOzm3zWQkkVzYKmhpZeofvhKdiNi5gmHt6uErMrXFs2gU7hTuFC35KjWbp3-O26BBHAhMlKp4VWXybQMwEfGds3crGu-x-9-S3V3zWlJcqqZzDscSGgidDiad_UapWuBscNgLyDJ-SCNb3TlmasjeA12IdKamRSC_brbvfkNvI_E5pKt4k3Ulu5rx3hkz_aK9hBg10seMKhpXXl8_XXz1Yix2M3vZwGF9cHdrs7K592alUm2XQjpfhVjz5sE9DNr-eFdh9SKzJ_tW0VJEaYgZMCENkQAdZJK3qigQ_fv8mgSJ9kzkc_2cFe2SKmsgbKbrKTEaK-vaHl5m23y7_7huPZf27wSSibaTJF5TPRQ_ktfvknzMCvpcxzkD9X9j23zclm7N8aQLSFqz86q7AGJYmiCRWdZq2vr83dwz2WpvoVKG1084zFgJX7u7QD3KQckyJiLmsmyB9q-LdnHmyCwvn5_vYdwld7RYQOMY0hx8M3o2Xvwgwl-QtNoEp7n5SwhxtlT0YSxKQeNUBKx-btH7Pi4xqObcvvgM27f7GA641pWfGY2nyoRJ_UeCxY8BoOxj6wd3uXvvdaP5RXZmiGRX64qg67f_R3xA6YZLL2_g-DNc-sihCMavAaVrSO2PgpfA--sLvxRWOGdpi8Sz399jPvxMSU6tCgdeouhbvkrNhFmSFBOeAFhlj0krFhrc5q9OT67osG3CXMkzgJZTI6oy5O1DMKLKG-98FfsfPVz68sQtl5NCiCMNGKk6_69XYACXJ8Hlssl_LFwNWros6zBT7HXOcu8g8sdGT7OlHM3EdZhDD5cr509XA-Szx6P-oAtmBVyhZeveuLumc5MhKXICoQe03tGFSbOIQKaUksqONhZpLWtwqsgHg2bCHELSN5yNo0OGe6lcTgPX7H_9WnrH8DXWeK_soJNOczVhndOnt6rFuYpZGQcHSsfhG8J3D5AbrAqNWsCk5RBngE0qr40M2LqERC-EeoQjEHQsNEwZeU5nbK0HYDhPfReG7AMoXX8u9wlFBBDDrOhVixu0XfivsXZI7qAuiNBtHaXEEMM9rG5jcarNw_KiIsNVKaKH8d1PqIStaur8ujgp2MqDzh19N_t4lieEMR_p2XLLM_PjV3yP4lKDylWBxCxfd8pAIOaV-J0iG0TNF1BNP25cebWONyS06Q0I1M2LIafP5s9R0I3L7teZT8zWJKFtKlZxY91dfUHcAqAgU3eFrRw4bthc0SDYI-tm608e1d6cIYgutr9o_WYYWs6JSh2Wj5xOjzcjq96zdWZ-fcKJSbpTkKp6sNTle4UFwJgYUCM1TMneWomXqU1GwBYbLGi7rH10hu1_ZVK-sxQ=w1227-h860",
                            Preco= 60,
                            CategoriaId= 1
                        },
                         new Produto ()
                        {
                            NomeProduto="Boeuf Bourguignon",
                            Descricao="Receita clássica francesa, a carne é cortada em cubos marinada e cozida com vegetais e vinho tinto",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOYb2WClRNQUfcR6Xoe8h06wAVow4rssaZ7S14ogjw5YM-68IIx9L9rIkGUWcTKe5FaaCEC8LKmvBGn0cXlybmwzKvysKhC4mGZtaP5uKCCO-1rjYSL4-7ehU6n4Ugq1WKliqkJqtRf-P-B9ISlQ0CHAdnqE8-kdNFb0MrTs3XbfAN72ni5aU1ifUzVo2jLAIOiTqHMugDNCwPxTblUS42XUrYjy1kvhQxKhJ7NYt_0UzT3OrOxlEPBSn6S78puTv-OMxw8ncQLI7KX0hq0eTPS4Tu-X8GxHBBbmI3aYz4lsgAMVRtxjoKZwI1LxlviQSC6QanqH1DkrgD5iamk6R9KgM-io-cmJTap0Ir9VpybhykeTTgu2vU63Y0dJFuqm5dh8ZLJ7YUHlr8wSnqjjkcWnQlAJyMaTzizr5h1ANhsXELFczEP2vsowSzg5Zyga8nsKCvLZt2HZ5xaRLWj0aLjXHRiik3C7dbPqPByoXFCv4EF7y0zsTNV5SOlcvwkRqNKFD5v28gvGkoBU_Hg1_QJx9kAWBY82n7KWOnbOfrCYqv3MB7PTOa3iky6wB5XQMUB42BMHDQnKquDy4OQPunsn7tAGRn_D-hQ5R68qBTLXDH-P5s40Nwbkc_W2SgiWo1AiFhvQ4zjDcTjutORiri7rZfg9nCfSP1CEqtU4wjTv2C-k3S-iZ86Kbiv_suZ5cS5VI1ymbW2jGt-m0dSM0hK2BybnGVmLHJ0iJCU1X-9B89bt9tCYBxCtuS1Ysx5eoYB17f_Tym8eFrKcUoQ_rQsJn2yL023Fiob6TtO8xVFuNrOLhu2d9AFihQ6tFEOGT1bgPvikiiTrhA9LI1IkDN3Tw7Xqg-VWO89fZ0zGSlxiQ6SY8U2jwqZsf0i-gsSB515d7rDULZbcAQTdGW4sQDoSe4OyGRn9RhxD44Kfyj0z_oymJmJSoGHGj9Z6jhoj8V_DoChmIdV3t9-wB9vKU6vs-PQGGVoDfbYZMyBEoIf59qHJ_GcpG4PeyLfB5Im91OT4GiqweqkxutW2gt_IpME4AEEOYnV9HOkSzDUQbgAl5gd6-SBd1pAHcqWkOTDhaTygWuc4fZFIIH36D8gmedmQzSsVKje7uMVuSfOq0E3Xz5rdm_J1JWlw2iHlWUsYr7rIoEgO278McBPRlIc0wuyHQ_DeIVi3D_46BsaP12FHATA-jJq-mNhFaj2i40udv5FNDwA7kH5XRLqX3SSWVVTrIN3D2b9KF4o5sl67UeyX7keE2Wkx30iBT2lc9LZxTyifILAnQdtQIcxUEpuEMpO45_5YxbF_bu-uAw1EzbSFFb2_YxcHfiw7eHr8tAV8wRRW4L290ep5za4JsUlu-UETHuRd0fK3Tkq6MTVT2FROKDjEQXCyGmdM7SNeEdu-QVoOIIkcb0Tqa_u0WhKhvNeyuh9GMWeGmTzKLEghqm-XgfoBjGxkPpFxSrN1zW-9ztTHU8Kpd3jY9vpxycO-qybt0UF141Fpd9RCuWt3LxF6duj1A_WdWuk1AsHYXnkgpA0uBw=w1227-h860",
                            Preco= 62,
                            CategoriaId= 1
                        },
                          new Produto ()
                        {
                            NomeProduto="Tournedo ao vinho Tinto",
                            Descricao="Tournedo de filé mignon, sobre cebolas caramelizadas em mel e ao vinho tinto Syrah.",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOYXkEyw-QzXMvo-hgv_go5urmf1SJKixyinkBQ__P0Slx7fjKDUHXLchMgh8xkjAK9itp50OG4h_YRKgIXhUbRb9JvASfmzkFuQ1op3BTzoYgZe232Qq9ltBi4UZ7F2qc2vZCWkwnTeq7PWp9XcdjNVpJDRgjdPmb5lyVMgQyLRHcBCSMkMgc-jOAqce7AZrmmdIuFpUX4NK7nwK-Zbq0vZxQQYv-j0AI0mdiL8Tiq0ZWBG6H4oB_hQC3nCyNgdsd5oj3k33jK1vjpFWZoW_vnp_Ccr-6o7Sd2EbDIvziibqcSvIut90mXm0sRNMZigE-YKegvsXFDOiLzSgEXY9ytHW5VAMAaljMGhXiGIziW0NuAJWkjdA0DC7eru7Yg0uT-93gk96A8JO4hr2-JVl4tkDwuZN9WA5oN9g22mZkmkUBV19SssiJInNCJNc6aSejDYKVUVPcPxKdnihdmhil1hrXQGb95hV8-t85N26CL3ZPOwQ0afytKpduA64Ss1SA7MpVIqKbDOhHBVqQumst7fMB2QNfeKlVoHcVlSTY_J4H-VxfTuIv0I2Uab2AN7h32XAlkU5FnvIbS29eo9b0az4cc-ijBU1u82U-8Udtxerr3nrIakdny_Akzn081P1JXUKTGXwQhAWfpcsv449FSyhzmXUZxfwIam2CVGAVz5IzMN89TIs39p_rx1LxyLWDN3VEUukPxySvgQbdfca15I6hU_-IlDDyJkM3IM_mDQIiLwoDtGyX4KsdBEkdPxgQ7JAMj7r5hJ4Zf1kfdEt9ACiLw_9d_sOHNMn55CBSKxt4C_FdZ5xXhM0OneHD0pn6njLpLcy8ZXpv7hntpFqC9w_j4vXep3wTQ44HYyo_Am5CjV6SBQQIBk0bsCE0HzlWcxJH2o6UIFxcgPfq_HqQCL363XDvfwDnKSt0kVdvs_W4aVoB6XDSl6igTUIn8re27VDeerwSll32qQadKi_AYUr5Ra2TtWXLQ--J12g4jCrq2RgyPlXfST_hNe-RzJbAGKoNMgALeBkhbFHzslVHuPTs5SEocJp8yhT69jKO3hVyKLaNciWNY1K_ib46FrxXApDtkK3wPxhUg92JP00sBTIGQnry8ph9R-HloeNss18fzUxbhu7AVQ-nJj_dlmeGojikZThb6O-NbW139RLoX10VaV1OgLjb5qW8C2_hWemzRsN6SPyMJRdiByYbQ3n6PKQwLGXDA8nvfFynoagTFg5Z8tCfFiA0ipR3luBfFBSSye5arX6QAyD9ixIN4IDVWfakYplwYlMrbqdSY-jYiyjp53Q-3xjhAotm13MvpWmQO2Gqw8DskCK5LQ9DUSbGx_aEo_vKnV0bSKw0QQrpSVRdskm0M0c9KuCPA2rRtPwfsyEWRuAhOM9o2vTqehv6tMjw0ktDWb-8tX9GO8h04T64-ZYqagjcWqJYiiIsCbLHh5TuzBTGI2ceniLDMwdExGw2BUWUsMCh4wrZVwQm3GTscjcsJn2_phufkBvMitjMyGzkRe5t4U6NB1vuj7XdJN2Q=w1227-h860",
                            Preco= 63,
                            CategoriaId= 1
                        },
                          new Produto ()
                        {
                            NomeProduto="Frango Mole Poblano",
                            Descricao="Prato tradicional do México, com molho feito com pimentas, ervas, oleaginosas e o docinho do chocolate",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOYwo65LPJ3OTKK0sofGyHC2z2HkIZVfE08HS4d-fQxtsKhICiqbbilKyV7weIoJ_SCaxVWf6RnmYTItWziMaAu5eQ5Qb_mBGaD7o_gvYbxIrBHuV-SEtDHsUoWHl5NvNoy711bnROKaza78OV68YoT4gNCNp7PPKCQnqnkiEedAaBrbaUoJVRACvMKQkC3IV5GPpyxvlEQhC_7JrdwRbRvlYMwCvHScE5Tb4PJ_1XUR99QTwCl60nx4OGTcJFfX1Dd3yWCV9Jvgh_wUFfhLNIz8fQaAFubu-MZG8RycTBAWwDx76ZM8NoD1dAidvSP_xJimiBrlf_k7xIlkQ61SKtSJa4CZ_B1UGsfADbOfjKvh_YTE4a2BArP-9ha4NYAcMNpo68Gbuty6_zVHJn6dqQC_ZiXYdgEHCO_HKz5aTD8pXq992v_7NSNf2DGLILkm_jO-WudcKLUqQM2As5crrCPS5eyTn27Uc2KTBbos6HCb9RbtOScp5NFvV5C-oM2XljIRCwJAqo0c3E5x8fRb6_YZKXfbB4ZGnYofe8-PmP6tx3p3MriqxTZZwCtDEeL5zv-lOnUKKdOTH8dO_jAjX9JleLE658BpYkJ3UfXPTjcJbZbFCQqje-atZYdcPZWhpTdPJOzIDn5PBGsAnxCMRKUvQildpPLUBqwY0s0f3nEQx5XrQ5DRyssPbd002wjbXXOroBC0fxsbFIJTIbfQYHVOmSws8s5217O-VcW7IIiQnHK8Ptu60LO-5N7xqATdhQ9A6ROX5Rvrdzym-pXPCCQ1sq6W_seXSSyhXckWRNv1lYkR_UYURKQQT8Yx18wmjk7eG3yedZf6uHYfaXeqYDcpH3g5yaSwQ-y7Y3FXh_Ypn1P7goAo_qyrPpvv2rXUw_VLh1cfdJ5OhYN00JZ7XLJUH9KoXHM0AjW8gaQI2v7_X0R8R9fxYusV4qEAlZ0fLtdjNPNgOJJGkEsfJ1_3yp849v6cS_6iCbzDqG7RXWy6dXJccQksriYD2zWRgRdyaKiPuzbRAB_UbGbgmkfa-gOufmob3EQ2_QDoUtJIL17jkKLEvvJ1Ylq2tX9mqtDIoYcf67EFlxWEpj8qetpUDrcERorX_00uEmiAbc4gvjPUsETzlvf1JWy6fR9-_w4fDlObXetYCpGQdDECojle21ZC7U_oUKM04fg8Y8CWVlG4s3LQogSt4VIIDAdMpIgS2hSxuBEIIsky9EhkApqTBSaURX6oT5a6YMPzga2FBxkfC5ZoMVQCYhS2QbhEhKqLPukeVK85lc0xVpouGODh2nugF2rsDkNO1F1uYrkydpQH8Lt7CNvoSiZvdGzJTuFsAkVNZvs6URjY0TWfgbFJ9DBjtqSro-IMWoZvvoDUJkILnN_7GcBQFvJS4WKpMmeAAtkS22dNXRC9Ux4gsJ-qtmlIXoLl3vQ6itx3mCaEajKsfZObwCLjBVuS_eWoVn10uzh2OSb-t8qyMExLnqOq2uVA_9xSgrOgdMUOrK7gYWc6CVmHVcTxA-wM4unQGUWePnjBpQ=w1227-h860",
                            Preco= 55,
                            CategoriaId= 2
                        },
                          new Produto ()
                        {
                            NomeProduto="Frango Kiev",
                            Descricao="Prato típico da Ucrânia, peito de frango desossado que é recheado, tradicionalmente, com manteiga e ervas",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOaPqlwGOhNYFzvexK2p8W825INnqS2VVxqnm5wuk0sc8uGeLXJISkrO8E9_OhTzzyy7Jl2alw4CwguPYEdJKK-37Rk3HAswZkSYW9gL3Yu2mLF6-W-7FIIJ_bBo6LvORnP3KM-Lvn6fM_X9sF8bGTNWgu11AixWUVjY1xjfWQ8MfPSltcPpwTFxeA9ge6GxT8J08ZDk6wvPClpbteio-1b5HsSeL-6j-BsQJGfUWPPtgzlyuVZ_Hmbs6XafvqyP1mnzIS0KbIzJvA3VLn5cLq1PSODEmVm4zRa8f_G7asxFiEYzlWL4ZEok6ZMrjZkpbMRlmHCJNyAt5GmmZ7J0NujVIOkJco3VA_eBdJnhlDH11ouexXHKlTUK0E5CNT1PLGO6Yjqn2cBO3GVLKjGOhniMvl8QFBzc7FsRcavdVeToDI6wBO3hd3qTJ9eq1wJ7dytxWg-URF-xc9sB8t1nRTpWmDga94PnuUlSA2daWbFa6HQfSpExCfMxhiaArt0_JxsYUumOBzTPzPdz6FYMHD-y95jUxT33q5Vz2jB-krDxvs0m4hFkm2WZCOxfWs_VyyhHjWulJ78_j8BXFD0XEbgqnUrj9cscnmmcPV9R0Yn_A_jz0HYfx_UYvgmkvlawNM26RnzxcpWqYr3kz389Jb8cHpM2tzX7ZcnNAkvWSeo-Kw0DklPJrBCMPpfsv0s526_Qk0kYE2uyb7b7K2OkymHlxW_9siVk3Q91LXI3Kk7ttB6712_TaCgeXMl-Uy6xolNWhxViEI9GQ8FAg_TkThMHiR_IUZ-z-cY3RF135GCwHtSBfooxm8swwlm1kkH9PqFkr940hNpGKLFmoBKXKMOpE57szOnVxYqc5HwuPc70DXv6Yx1IkNvYX96rMqUYziHPSCegkRhE8tHFHhckRX1mx5iDiuxzUNhz8Vv8KnQXF9RiCF7pOwfspg3PoOjxyfkvrH9-g4LBEtSJrurlGNGZTRUWrgj4_KB5tdPxbJPc3SZUDqhzpPv13jacdBpLZTN9Vn70r033cHepR1aWRQT-IgEZjtZI_83WPtkHSvLMWm43dX2p47k0PYuDLzmp1e5YrgNzH34s3TA9Wue6jblnlf9-pQz1nJ_umiQdm2T2s7XmHirYjUW8OQDLUPEW0mAt-JllLHSFGEUJhe9iQ9IO82l31A-rdbbZOPo6qa_kRkO0MHDXJ9jz7jcuuPcITzHnc8UF9csXgu49FVOfIl_0Z4EPBJMCBUCXCLiXqy2SnUcPCIr1qw7zuTYm4jUwuXQQ6NldGVR45xr5NkHCw5SoJaA-7ABM41pAKcFKiJaE7PNXkPlNXNCKb8XKbwOxDTur-e1MnKXbkGaxJpDed0VrWGBp79l-qhhlAq02Laj7r0iM8wUwK7OLIdHUzE6kehw6QIYJKApK7fuYX5HaSoGZ6IB_MQlLg-GBfLUbTjY2ZnzWHuJzTi48gMRuqUayI7ScyUXWlBjI05ZI3_s6kizeGXWgZ9NmyTjszCDmuL9YmOYQpsqgXCATvJQcx0MdivV1XA=w1227-h860",
                            Preco= 53,
                            CategoriaId= 2
                        },
                          new Produto ()
                        {
                            NomeProduto="Frango Tikka Masala",
                            Descricao="Prato típico da Índia, pedaços de frango servidos com um molho à base de curry que é cremoso, temperado e avermelhado",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOYGrdZakqggcaYze0R_yZrgNIxUEfx2vy5GSwI9yBpgXdFQ9ANdLPrIhEjlVMiBS6dGYEQ-kLN0_A4P47FXBVZrlkeBWIJJFt3MptA-CxVpY0flbSujrfQuGQqbEaFBSt8phicclK0uGCrjD_0NvF8epNMIGG236vp0JoWfik9Q-473kiP1NWwFnQ-vxeFHoX1PRPBUYdk6CfYhAi5GiIfbPAZcIfCDfooXEPWEYcTEvKZed61EYYEhvW2N60apwPebYDYPjbMX0u_5JJZFMryPWHnWAf15BXOozAgD16QARb0U6Lo3ewFfgGJaJFdxGAwUupfU6c5Oh38NH5YQ_wqWEoiFGviFSh5b6eldYlTMkN0qUT2X7bmnq1TJuAARIBU1_tCNOoiHyI6IRf_h2Dgu4QLlUaBCvOBHPekMMXa6ZJXUyR8tXwrrBjUKC4wJ87nLCGK4P2ajofjAhbIIVXlRj2r4EJLMvSyG5c8T2rqrycvJP2Gvr0FV-2YEryucA-KFxt9SB0kURh82oE9bsqjtc66011t4_hj-wkN0BehcKUTdQJ2dGKThukUjQ2Tf0VTVTUNiGPfUTR8cQJVm20tYOza73awdGQZ9WOqHNuPSa_PZPqzB89tvo9xMtFggUQq7LLwV5vbcORsMARvcWN99RIm9khdWhuktn-n9GbRsfgE0b2AiVERR-KTraomUM2MNkGy8c_9fDwFf3UGgWVqnvytMx2Mu_40M1W3DRasZqudeUDBBgfUU169noqV1lo4ndOrHmZRFgcJVFSBZzLiKjARM0OLJuM7IT1Bhwvp_CWgynk75clw_Oqq7N4PfXGZ3Z3RsYVTz3MPoTvONlvnhbiocV1IsMEUV5G8nOELwha_fB0XjG3_cREe4ZWjoWG96obqbc96NbKku9QOfCOB_zytfJILs-MJK87WFirMCTAs9jUvHIyeyMYci9XniOc7BTGb5Gb3jWgodhFGcglr8D39Eax1zcFL_bMP5x5aaW0e9Al2bYZhTn55N8sNkecyWXKoiCu7FfCc-Y6FHzSxOhQvOICm_KuD_-6cw5N2_gOFUcFGlggqF6JyPwBKYbQTig24-5voXo6FfODXu5388-h8o9PfgSnqjhxa41pfVi1M9tAaer4CwdPvw7oPbidXctvz8d8d9D8krJozoe1K6NQKy57sPF3ml-XYYWQPoewZeN6yVxuu9xLln9jsoT3EOojfI2dAVgLQjcP4F0LS2kVJKbr1AIuEp3m3WkD8pzbIZEr9bCt8yTCJ8Mv7AphfBTPUDysv2J-gY7sTEoHLh7Q-qTfNyyG2IMC2b2tH1zaDIbvn_Nad6yRRoEly7fm3_BgwXOkuOjzh90DK2GG6Y5eyGqCOg05bT_O-9Lpjx60L_RZkAZUM-p7AkT-2UVef0PAfB7FZiRDzF3RMk3MwdEeZXSXjClzw6gaIDCr9qZCCYOqer_G_NW4w9zJaFZmDxl6BfJawahsoQxjdgzozW9szPNuzV9tgpcXAZ8eYBarkrfseKd9jk8X8c8zIwJ7Mb6A=w1227-h860",
                            Preco= 50,
                            CategoriaId= 2
                        },
                          new Produto ()
                        {
                            NomeProduto="Churros de Doce de Leite",
                            Descricao="Churros crocante com muito doce de leite",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EObhufDwzT2zV0-D8nL7KHExIOHSj7bq6K1QUZXvHLdjlD55LWjusupfrCGFvBYybRDwKD8o0hdPNoXSAitWGuCxiUtfrSATDb1sc_OPYlcIf2OT90CSUIx3Y4bnynvdChv0tJcpTaoGg08wipDyI6SdD9jfbo1LGz6dUBIU0hcKf42fXhycsKeP-86ZA8i8Eao6-TGjMXHSnOhHqScxITdUEuFRcIz9xkFI3-NtOL23MF8n-_d7mG8gzK5cLNlFoUAjudKA5V3H8bjD1fAs_XM_hc267NHe7ykRLvI9ig8jdLzCKCeuKgF1GkzyLpY6weJjIiaL931F1X8sJP0c5YA3OTDEdGyO0wWZYo4dM8-SQynqPzHq3faYYT3eA6J23wQKaxAJ7qrHluuZCB-UmEbVF0rtmj3QyIOEE5-AWVqNT6Oj03_i4NbfSNuby85JKGvxDWP8druPphk7wHuHIMPFhpEunr4B5PfqmxAkM77uy8kDiAL9WWSWaVIugZlkWoW2CfYs6x9iGMPNt__y3yZi_Lyha_ZHLz0Qe4-Ecro8GyzVEWBO9gkoxdSVlUqCuCAg9nPny7X0WXvmwJxX83eEoRlfY_J6oDf8Y0RNFGRdc1IT6NY5F1pGAMAWTRAbqnk3lGpdYI197zQcrd8dMFpZe3Dx9vcqo-Y5F2bbv6W1W3RmcxkEyPifmXPud1ce2WeBYcdSNbpx_sxQS0GCE6wE4vGYGvmrLccLEIc1qxUq7Uq2WHuNfi7aInNCg85ovYu60dltObQdg5sD7cj-lmUkGAojO-WoryRUS0FB3L7WJ6aPeMGspDjapxyKm4mHrLTxMgd-AzJLsOMZAhlvuUJyfGrB5lLFFf_zf3ZSWo09Hytm7YsbD_blWYU59SZdG-PDMAU4TXlghIbvqeG89SyGmNRXNpTECjYXWRhdB2k6GrxnnXMnsKyLmWu5jsJ41JVT18KPS6w3onDdU-dNzUMSQmF-dvhNhozAB2wAaSkWKAybkpBXrSCb8KqX5Zck2QYSkVh39VBW8vLPOM2TKeshTsv6tmNidgBc-CBFcJjr6lBEp3kf1RJWZ4f1xJw9x0mvxqJ6ib_4Uf4xpX9HzHwPZ23Emt9NNsJTqjDKRzU7imMSXHpkVeXsjcaH3eKlovSaNvWnqPvSVfDKMyZTWuuC_R145vzYhJE2-9sRA6LWIlRaRe0XU11eJQSjA6IaTJJWLlVGjkwX5rpt4p-8risrZiDqGcxLArENSjE3FEWZm2xAZQde9YN7x_605YnOrZXnI2OPmoblAgwL0TuTVAj3QNYj46XNqWWW4WL0DcX9BPUgTvjJR-yt2uAv6avsSLLmagzo7pMUpVi9-NhlQLzB1CuiXMAnveVYfN3zVzarMCGlF8QoI42E1P6w3AJ_LZpusuZGrIfMny82PUjIUQkBWBtN0YMfha6mn6pSMGjS3kJoEAOaXLVkkXFIjHH1VgBFXBSZZmojfFoOJtp3Py7faaUyYPjoVPq6z3u0t9LVSLkZtrJ8YQqLVGBjoqRZvMZHSg=w1227-h860",
                            Preco= 7,
                            CategoriaId= 3
                        },
                          new Produto ()
                        {
                            NomeProduto="Churros de Chocolate",
                            Descricao="Churros crocante com muito chocolate",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOaEEBj3BhxPgYDN9F04jcrfve0H1bJhyxqNxDZczyExvclNnHmacTaaHtqsNTTcwlh4Hm7_RKHp-HzYEB7Wev4hpZy_MaRFBy1iZU1AfOTQoUX1Fd2FwaKqpvTVnm_4E2Kk_e8fwwR5wqhdpCraQLPaxq67GPXF1jR2uBz78f1_7Iqwy8Uiw0PeztjwQFTNlXH2gksUuFCRrBCryDjUY7sXPypm4PsINM4nOpDRYSvOIU-p6DURKz1cU4_Q7ShZI5-J1RRkHB0hkMMyOh30Qga0CWygICyihpdKp6zqGv3zZiuwHk14fasF95TZNzUqI71CNlEzNFVT-QU3PhtS9rYTCFF4IqOymF0OIgCS38GlDs3tntERfec2aT7qlc897UIWXfI6jZxV7lbeix_5w2-9sO0PBWsgUvY2f3eEw6jn0CXc0qqrwLhMJF6AFfM019CAyrbiiNIR8GI_x7uakTnPl7PLJHXDd3lRnAroy_alVcoJom06dNUNI3DeFCWxDZXg9wHpXSycfbgE0yFsO5VeX2E0XgD7Xo3uJCe_A1Py5neHKzieLexaUmsapFqp2OHVN93n29qxMWnF8KVDmpqoq7Hk96VLRX64mQSvYz4SZLvBEULZ8_daHlpAPD7hBRJCzboQCPpmaLaXocpvU0MJNp2BCGsF4sY1uNddGAhSsfT8pCQf3uqqH-FW0OhSHLG6hhKQCrHRer0GBaqd_DnzNmngyNj6vYl4SEFaxjJOVq7PLNSuOvWFu6sfQL2AeSPF5sm1PdsjzbJvCvR4oZzHRDDNkuw5EKHtVYuDG3RUSv_2K4oF3KSf6HqgF1-JWytP_HY5LV1ZTivTzPi_fJCJnpAGXLW-M4FWWC8YQqw3bDhqSQhMYl8v53UebEsOGOaaS29r52rCM9KjFEGvpZ_4mu6HzcejDcptdzKWkZxqjgZtGwfAfy_ouv9IeZe-2-EAGgJmL90nWaQesYZMRFVt_4rXVupJvkIo7nSuGepJ4wc87t0-WNOivroWl4fKxJQt3h4yta4s2Gpz3CP9tZUk21BrmkmDyPhtuU2vReJdrJdYBCpHCI7pKrfVFdsYYngeCkAgyBjcOXYL1YyqppG29MMjJcnyVYwoU1jokKHPrWtrZGYnn1swlE3iH6FzKxV0dxMTbLqRWg726CEENamHZUVfvPY8PbntOEb6LWt7-qxjVEhITNlKENnI9EVKQnQgXqJk1OMilIk4DawgsxuT7Noz2UPR-Gd56hYHGXMFVJYgJ5dPlATbMoHzJO8oRj_-19qwjh_6f8CEb4pzV-yk55Wf_FDuUx9FPTY4GwOWvhRuR5lsaauuyeoUPhON2RmTHOhOE2LvcBSQAquf4tUsfiybaFC3ch0hkTOlMABwwRjhpa5m5tUe2JM3SkhGskV3KnIKNkOyyLYtHe8-O5X_IYsG8ALU1Qc_vZrujZ6BvAlIyrAX88jzZnw_Eu-94Boq-dJ7FXWRJvVOlvDuX1ZYxn61BU_pZsVE0drvV_bkyP7BowYjXyqD_fNGslu22XbYDA=w1227-h860",
                            Preco= 7,
                            CategoriaId= 3
                        },
                          new Produto ()
                        {
                            NomeProduto="Churros de Chocolate",
                            Descricao="Churros crocante com muito chocolate",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOaEEBj3BhxPgYDN9F04jcrfve0H1bJhyxqNxDZczyExvclNnHmacTaaHtqsNTTcwlh4Hm7_RKHp-HzYEB7Wev4hpZy_MaRFBy1iZU1AfOTQoUX1Fd2FwaKqpvTVnm_4E2Kk_e8fwwR5wqhdpCraQLPaxq67GPXF1jR2uBz78f1_7Iqwy8Uiw0PeztjwQFTNlXH2gksUuFCRrBCryDjUY7sXPypm4PsINM4nOpDRYSvOIU-p6DURKz1cU4_Q7ShZI5-J1RRkHB0hkMMyOh30Qga0CWygICyihpdKp6zqGv3zZiuwHk14fasF95TZNzUqI71CNlEzNFVT-QU3PhtS9rYTCFF4IqOymF0OIgCS38GlDs3tntERfec2aT7qlc897UIWXfI6jZxV7lbeix_5w2-9sO0PBWsgUvY2f3eEw6jn0CXc0qqrwLhMJF6AFfM019CAyrbiiNIR8GI_x7uakTnPl7PLJHXDd3lRnAroy_alVcoJom06dNUNI3DeFCWxDZXg9wHpXSycfbgE0yFsO5VeX2E0XgD7Xo3uJCe_A1Py5neHKzieLexaUmsapFqp2OHVN93n29qxMWnF8KVDmpqoq7Hk96VLRX64mQSvYz4SZLvBEULZ8_daHlpAPD7hBRJCzboQCPpmaLaXocpvU0MJNp2BCGsF4sY1uNddGAhSsfT8pCQf3uqqH-FW0OhSHLG6hhKQCrHRer0GBaqd_DnzNmngyNj6vYl4SEFaxjJOVq7PLNSuOvWFu6sfQL2AeSPF5sm1PdsjzbJvCvR4oZzHRDDNkuw5EKHtVYuDG3RUSv_2K4oF3KSf6HqgF1-JWytP_HY5LV1ZTivTzPi_fJCJnpAGXLW-M4FWWC8YQqw3bDhqSQhMYl8v53UebEsOGOaaS29r52rCM9KjFEGvpZ_4mu6HzcejDcptdzKWkZxqjgZtGwfAfy_ouv9IeZe-2-EAGgJmL90nWaQesYZMRFVt_4rXVupJvkIo7nSuGepJ4wc87t0-WNOivroWl4fKxJQt3h4yta4s2Gpz3CP9tZUk21BrmkmDyPhtuU2vReJdrJdYBCpHCI7pKrfVFdsYYngeCkAgyBjcOXYL1YyqppG29MMjJcnyVYwoU1jokKHPrWtrZGYnn1swlE3iH6FzKxV0dxMTbLqRWg726CEENamHZUVfvPY8PbntOEb6LWt7-qxjVEhITNlKENnI9EVKQnQgXqJk1OMilIk4DawgsxuT7Noz2UPR-Gd56hYHGXMFVJYgJ5dPlATbMoHzJO8oRj_-19qwjh_6f8CEb4pzV-yk55Wf_FDuUx9FPTY4GwOWvhRuR5lsaauuyeoUPhON2RmTHOhOE2LvcBSQAquf4tUsfiybaFC3ch0hkTOlMABwwRjhpa5m5tUe2JM3SkhGskV3KnIKNkOyyLYtHe8-O5X_IYsG8ALU1Qc_vZrujZ6BvAlIyrAX88jzZnw_Eu-94Boq-dJ7FXWRJvVOlvDuX1ZYxn61BU_pZsVE0drvV_bkyP7BowYjXyqD_fNGslu22XbYDA=w1227-h860",
                            Preco= 7,
                            CategoriaId= 3
                        },
                          new Produto ()
                        {
                            NomeProduto="Churros de goiabada",
                            Descricao="Churros crocante com muita goiabada",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOaVl1bkvgsr67c4dZL4tLfrkndLyVSNV5BnuZ007TSwWNYaKfbamb07q9f8ujIVcLI9Nda2nPQ0SDHSdvt-GlZmzB6Iyk-cScTeLhTQ831k9SOw7YfyWz36F88Ohwt5FYsWw9Eujpj5c8xXNsWeGRsrdjM8uEC6ix40l_B4HcEWuiIT2eYnq5TqbC0p0oxxzKaKIIiUboj08WaJc1cxp7lhrBu9imdBR1Obv6feaEjyyPLUwVb3OpyAEzwMTjdwuJV7m3jmMqUKxJh2uzA2VNYM4Vcj1kgDCjRtuFoK01qc_4dJRG-ZB6lr2K-ZRJJuf3g6S77-lpdfyXAoix-L4ezBExtHKKXYe6PQJBTQdZtHSnohRAMF03Zp5jkxCgiRjNCPllkS01B2OhfomyiQV9IEKEREcSTiW9K9-xvux6X7PR4h-tl6V5lNByEGkRm6OGSrjTdl9U-nupFfnf06SkfCIXLZbYzHznCZXz46x4YczkciPgA4_ccE2lu8EPGycRG6HMsH4IzYpf2V1iSpsShcAR-TeiWql5nZm5352a0pKZrDuNyfksiWPEd6JF0WnYI1nDMvQqdJhzgs1k296-2yTnW8-GQBYF1UARrd4hvKfjxMKnigCvTbB1ArpYFpNqe-glGV9mlrADqfmsU4t0Jb6tSnpjxUondZlyeY-mwoBrQcgUMG4XhVf6ox6_rV_i7GHoeRKQAVZi3cacx6tWQpNwSAi9NQnidpbJdTkRPDjxrsXP48G16dZqr_VCfbRS9PubF2gl_Z5LgzeTYbAAiruzM0-QMvzZHb3ZIfy7tjF3LEXHaopPWQH6TC6TfZa8FI7VgszUIigxeY_U7FfhkWDoVPGPSHiMC0nBwiCJ0sxp0Ok9zZ7i5XmK3tdjay-29_ySUgFar9Z4uwv08QSlcwQIPDsC8XtzVjt_Yoqa2nmo6xGK6CAKQQBUNG8dLRJSHosxmXG49AuN4qu2rs42czAhhFg-chzNE1d6apZTuQ4eYKuh57zVq5qMyN8FfByZCUlCe9OSAR8qFNsqMZ0X24z_Fts77OiQohkg64XqNlHD-42nY_9dWJ7eBMiVoOk_wn1rp0PuSVwK3JsVbudWHgtbbIHGSlg2Fz6UGZI-CEOxFOggiwOk3TcUoCjkLCN9QdWD8vTuY7sFGlRIyq19DctzZzzSnHqXiQ16ONSI7JUZ2VmtHYXvdylemTuihYoWA9VyDL19_9QcOHYqBsS5dmQCccNTQQaTbPNg759DxfoQ2fLgJKt_zZPuyFjX1Ltdauzgj2mIQYOzKSaljZd2wAK_dPDXSSFNcNqH0zP9WByU4_aIkAeyL_2H2eBJxT3dQFK98AzX3byVQXNvHdLgSr0yEwomguw-ccgfjht7JTVfddYDkHTq21flEFEMsydGtbfodr1fTGbbTVypTI33T8revKjrf9ZCze0X_l7sMBjhTIwZb4euIh8mY67LWwkf5SvPUt-RLJh13P5oSV4VWGMDk-8V7xYmvG90Q6271_sJOA2jiaswSVn22H-SjGlb62HQ=w1227-h860",
                            Preco= 7,
                            CategoriaId= 3
                        },
                          new Produto ()
                        {
                            NomeProduto="Churros de nutella",
                            Descricao="Churros crocante com muita nutella",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOapSLmiuBlokYhkimHMM8xzeN_QXoqjrfntQ_fYBvj4tn3IXe2OAZPm5RJg1R_Ov91XeIZSGY3f5z5ZHh08faC-3TMSIVK36gL9g5eqk3Vnodv2ggyljutONlVNLa5cfqWnfVLrB3ITeKo0HQPWKN6KNBzu7ULIcDX_UNKa8UA4anxxW34DQO6HKeF82lihCRwLbuNkdLNTh2H71hicBB3qm660n2hb5lh0w_Jxq3IPJyjuZnlmDFa0ARG1d1m_LWttJpCcA_OSJ-aWB1aWxu9Un9duQouJ7zeE-TYYMrUElkxJL4Y-xZbLF4ZeQSbYd1FZObZTPbRzStm1IkNTTQ44yJcrxUjbvBuCgQCD_38huFBwhG2GAdNZZUDl_l-Vzkhiry93V2P2w9ZoFN11NY-9oz2DYWa78hjmN6JCHCxCM1Q0XU5HqSDKGHI8wE1JAQKa0wgdLsD3WiEmjJC8ujB_SC96wcXFv03Fi7jibHA2JwW2atZqqoe4Qk6pWI6YSIEmu7Q-0DbFnVp5nf3b3p7oazE93wAJwNwq4RimbEJO3pylfpYKvcCp6TiLHem9Tkny0Pk1_DCp0DCIz6EGOUGBxLd8FGhNV4julf5zPQV-OW08OWEpCU-Ma7aGfwWtVhdGCpIGDx2VSgJd5K9xeGp8etEK7m0HpTa8LdOFyjfPl-swSF9ag3LRn1vvyH88cYczbB3F9SzbKK7ILnAGZeuombjAfM4tT-FyIuL62q9QYuEAghnn8teyzfStOyE0fOGTf7N43O51sPpOG47eJCL2TdAsAfzGj4TVfkOM-GUMBKfinAhG1ZqtQAhBwwEsjplkshdyUhcSlVoVKI8f34dLP5aHwgE2BpVLHmu22PmeOzbmGysml_ppZE9alJTj0eN_OCmfVwMvLvntP7qMXezkSH4Z192WoHOsEKk8y8yNMJvB1cXGs4xS35t2lxruCsIUvodZZ9HQ1P-7OMzrgDOO0GO-xw6Rcw0B0fmNePIZ5tXHDWr_waljVCEMqgkE5yMpDmv6aYBb55Hw6LDUyjr0vggwQ4ZwMm9miyNFv6xvaWN5dVgE9t71zgPG_R4STL10cN-NP_55FCBVY9fBN_onkmATag7l1qpqBPws2xhDBE8WQdaH7Cadvl0UYsgvmnq7c4iu2Y6N62oqgjZK8bV0AqLLg_xru7_Kw_UtD653DJVfOAdpKsDjOmbWKqFd1zWncHiIgz7e_Ho9k8pypreLnx_0RVrrjCOdY2FYRAIWs21mEMVKtMplFrfTkt2DvsGVEFTuT4-EIs8cQzwdKPID8_l0vauKkCTt188EtSxy4JUVEIIDXxvRJlWA1F6ELwk-3fjdg0XbfbrLDxJw0K4rSTIFjFUZnf3eXXA_GZrNeKFh9hItnLlrHYBROs3SsZ7P6_mOV5q7SiujRbTJZ2P0zsLWXYHCDUQB5NNS5NqdPSWrLGdUjGPEVT07rbMIfEsXumBNefuOAl0SljHX2ZwAGEVncg1h25AyzQB6Z5jKwyJ0M212_Fg1hWl9VXJmB14UVw=w1227-h860",
                            Preco= 10,
                            CategoriaId= 3
                        },
                           new Produto ()
                        {
                            NomeProduto="Café com leite",
                            Descricao="quente e cremoso",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOZN_Y7byIs4AaZG4emNyM_uF1PogeKvVMgl7M3updShOCqbVDLx-iTk-sHaGNTzhFGJlIPq3BD0rSVyU0cyjQY11yaGit_mx9bOF5f04OGWa3OGJDsVR0D3LKsajZ9D1rNqrT-sByZMH8NSfKpfOJJPEGMnD3iYLN7BLx4QqSjCWnMjmpLmPbEOkbX5VdOFugCFdOeiGo_fmDwImXoFvI9286lRSyN8eoxazURFuzOTfSIUCWo2okz8vfGIC6Joj8QMXXMUTK4g5uJ0IgQ3e8iP1_N_EnxVbDunydqeaVLP09D9RIlqxtd2xs_x1hilJRg2DWHXjmO9KraPEbh2StaHuwTqnIMGS0SbcEa-sALXY6c8VHmOXVHVqf4LdJr174mosIy2dmfoCNbKEEl0vWMRxzQN5jEJ10wbz8pil3Z2eXEcaSRMQfC8KGo3c5k2u7W-rGcwE9fAExlYsTIka50WBBX_zH0L2AsAM5DE9QnS8CyoBu6srWZUxqe9BPsSGqPco60D5ZAS35i_Zf0w5mvgjLE7x2C_zhFlk0qGp2LDQCf-Bvc8ohzfi6QtOU9xtYNbJwlHtEnG5d1UmJzE3RCyS07RFhUQbJtCOBTGdpXZLZicLViw0_J0rCOcD4MXkirEtG8amBv7WohQ-ou76fDgc5Rz96iFXiS5Uqj7r5ca1A_WzLMqG9QzhakHrvN8ywf0NhXS1-CkevniW1ASI1FzKTDRz8kxA51bz_tLJAtaNHzxvhCvq7eNt8XjPssm_cz7M4kcWiIS9APJhV7Rj9kFR3CtfucJgLpt0qEfNLss9sQ-UTU46lUKbPa-OSn4bU1nQdZsJd8OSDvKsjgn5z5Tjk7V6EaAVpwQCqhc1TIY2JdJG0SVoNNNP_uMFg6eRsLn5atw_w39l0PKQphnYd5Z25fsK2lcg5ReuiVuq02LezLQa96J35hrwH1XmyCwnu04j2sRt0iugyOV4ohb8K4R2kUlL3OvGXNpuAm_WXm1joGgO-ikC-ES3HM-TN3Lni9XuJyY2zQ9KxEddtixaG7TkA9aQYlnaU4nxxsuREOcAHyzGlZmsVKvzBsxp5sVb-F43Fpxc9seaUpsoW4HKO5CGi4_B1amorWdUK1_KzXHDbvRYdcM-NbfpmoUQGJMBVngUBWvLw_E9-1eb2QqpW0Nxg4neRF-Zv5G5H9On-Zc0qxM7_vtHI4YQ0P2vUEm31OjmFoc4WB0XY272C0GF5-KFmWYoJwCL1aKq39HcICXgvGX1QNa3NU2pMT4idO46t5mTHmshidsEsxpNznr6SAjWT0jW-ZrI3m6ePNJ4D5BLlsnaD6sX7udi4nr0Reble8Mdixb1LqB4aZq2LU1FbgeE2P33C9WWdR_43hQne8VodXvlp2vCwOFip4k9uX_QqyebF2C8ZH89beiqBGWrSJtk_rUpiGp45qq_aOWXjzk4WKZBAPhq-K1hr3BmGgEDh_9SwzeeBJbv-sLFPu3g4NbqCIdYdBtlnhPuGk2BNYHP4PmUqMnwmMq7ndBglanArPDfw=w1227-h860",
                            Preco= 10,
                            CategoriaId= 4
                        },
                           new Produto ()
                        {
                            NomeProduto="Capuccino",
                            Descricao="muito cremoso",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOaerynqmgXuso-bd8HDKkeLoSZjsVczP0XWcSA-hczI15-lpYNMhkhJpJseIXz2hxBIoIEBJA-v5XvgekXK4mDTlDghBnSsTf5qKV2gFg8INmneVzNUQJA9vsLZHGyF8NNBKYzHK6koMLXafk5n0ldlairvgLCkKRsQbAM4Tl7ryZm2BVUugO7twNfwh9YS-tZrBYE_YeQl6XugIw_tg3jwi2dKjmsknFXsVPydWaSbShEhd2RzQBoVL2U4NFrUgsg7D9PqIYshX1y8ukkZHB7XdFfDn7LCbvb9ikeYM2PMuCl8hFu6udSlw2BVCPvPdxKDl23cfbLs7nJ-EnaRb5pC_pzDRJYLukkXFE4YRi-2RsKzU85KSQW6lFHdcGphflb_nTY2qA8f1o3KPBTJg8yoMK-B_olNyccZ0Oe7RKCqlVD-wKpnqNd2oDif84ndAH7bYdVAth6QVwU-vqL8NbeEQYVamo36OWr1BG21EjdyVDK8TGcp8niT1Bxz5tPcpk2IwAuAEbaiiXnFZvdBh7IAUtWnfDKdsSTb6Nwc5LqxypRWBbF9oEWuR6oNDGd51mpXtotkCjQdjWsejIBfD1Ezasf2QKjR3Nv8vzMg39PIZwqTmKaq9gT2cuStdEX8z2nCc5MNvW0wDYz10DI7AONO7F8lJLefd8gdd6XeHaipRuKByewimnLIlg0v4B2D5xk3DtNDN_zsjT627Dn_Ek-hcZJ94Jhe99UFx77Ub4BY9tRCH76-d7EZD8EUx62mC60hxeGdIpKS_Hzx0DMKLjRrqJGbzKStGX49OisTR-n-LaRwMMDS1h7pXXaYQkBmOOoeuJ8iw6kTBLrHH--6alUu-Pw_US2SC9ZjTk6iN9URTARw2wdt2Y13VBoCUNj0r6SCnsV-nfNhJuRa-B7ZDVZfv-KVm9xaGQFkuGRiuQ234bK2NPg44u_hK_3neUaoKmlVnNCLwTbIbYF21Zd6YcoWq-3eRG7mRMGN6I3lyur4_Na5odgzoBs_C04EIU6pZw8ZQZpbb6xNlwDDzC0EemtdosNwAeA0hGrXjuWp_3AOuYESDs_1ZgPJLUE77PN__uRA9coj4-OfFETd0jMkAmhdu5ppY9qbGh2h-m1N8xQutktHYaA5z-fjPV5hP5PmXNEY7Vxgbtc_ok72awoEbsRo8yMw_U1Tj2lCcl5IzzLzzzTw_5PAjgvp1eYPvI6XRyuCP2SH18JnE2fiEBsqcnLJbTJgdMoJLb_PWJdopTRcjxufcMscNqt6ssjY-72Ap0wGl3ETS2FpebC_mI-Uhbg0jNtnExEzWTV6UV_4By4bU9Wa5_AzRbxhHgXAuL_lSJPCBym9yGE_Zofq1VbPAVpdqejzAjgyVr1tHMfUVauoBA1kdr8lpT_3FzMnsTXUIDs_RGQsQjVDWvwsFeRyq899GsR_7QppwcMaMnZ8x9YqBCpydcNfEBH6yYvbehfIgSa0gpyNBu2wlvIbZODhHGBKEc0_74W5ghTxr6KgiziJwJtgqIBkzBTCe7uRrAwtnaKo7Q=w1227-h860",
                            Preco= 10,
                            CategoriaId= 4
                        },
                           new Produto ()
                        {
                            NomeProduto="Café expresso",
                            Descricao="tradicional",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOYmEUjkrYMlSRl1CTJnzhBXLe-tSKYGbLwCWOUHe2UA_seeHz1obnboMz1RdXWgXSfdaRAIf-s9h-d6r_o8pLSTKmQD6QzCOwmTbMz_hZCDg8dkpm7atjTU3a6MpVH0R9Iumtdfyrio5-XQdU5EaRqW0oEwlR4drgGfNVW2HzNyo5bNwNUzaw9AszhoTamC2qZuF1wggl5X2D8dJwpknzqHAMGf20Ib24HtlYY7lczEw9UiqWstkJPimivMs99AKEDL0qk1ERwweubZW23HOHkuurgRlX6fUjTkqSia5wIH9ic2Lqk4Ve-AVuFV0f7kH21lRlUFpbDsM6tOqOPSuF64sADySYk4oldnfWXW00wCYxWOya10Up4yto7zpmnD3f4ziNtJWvwH_MktRmyRV-JIozTXNUJdTCNGgOrciddkb33XzUidR2WpR8cw98PTUWuTN6GZ7NnEqVghjKt5Jxs68yFYRaveS9MEG2z5U6kU44hNyfALwOTu-Nb1iAAci6x1gI9BkzAWvBnuoHPARxIP5eXr77G3PycZ7Z_tBAeXGHDCu5t-4xtjkNXNDWyYE19jmf3uz1co2o88iNhWE7szXc7JiFrp7d21x7MX6r4AnkEuQpwUbdO6xyL_OHh7OcKxbQro2kJ2JpbBiZLw_tP0dPIuyBLeUBE_vFMkntAPChlDm4t65Sh9AUWuTcYmri-uBAKW4xnwE0-iKKU7ifdtNDD28nQkmjnDo8F7_c-QpIvciIBzwIvY-Q9DkpuJH-Jz3m6YtDqfzmtxImfSdBDTwJFnq-BbpYf8sEXSEQq5xonp7RdJb5yiK0_fS63NjIH-NzLAXLYJrYC5fOrvCNQ1c6MCiyCu8ajCuU3Le5WgIpmicV5674eh-86AWHqsZFL7GxiYPUGm69AHTJWscovszBerCXyOwfc-tOYSqTWS9MNSGA2Ll9Yd3tJ4YTz5gNA9wOqQMYYusx8CUhA__nCnQwQnzijLiWhEiHXb_C7czQ0we6048aeKOc8uwqjhW-mhlBLkPjuSuuHF4-rH011rqsKBaQTxeEF9JOQ7cr7srQnGyt6uCs8hA1u5VmxR4lG0R4UzZmknLYC5X-gcnTm_Gn6lCOnoOF7nS-1NUBgY3-z7LT6cE8Fd-BfJYHhP3u1srjrWD3Ixpr1ljs3fqQ1KoJCSNB4WBCxiNc0CXvqJYExTFFYuyF8UHW8W5S67b6GjpJPceRTwwB2CiAtK0Mk278QiKJ6BWXujI5U9opYK7U3zl8RPkjUkga6LbGT4mm1VmYomDT0PMNDtlT8CmHrzDe8WGXEzzaWa47BcHj74_E1MvwU_PNT8z9PxFDIiIDIerZpxxQIbvJV4oShaCyHhJ90fkTUaZ8EHpYHu4FsphWT8JQYvLglXDDK3zbl0zfYdJ1oD0-jXV3cO2Kezo0-VC0z3dWu_uctWdCru7IJ-6J-qoVpOgz7IjW54Sai9y0IbeZu0RHmtU-hpjBQ_4OELIfGY5Sy-Vd4XlQcXYlb0yCS_x2Odri0Ov5mQU7vV4VOEYA=w1227-h860",
                            Preco= 5,
                            CategoriaId= 4
                        },
                            new Produto ()
                        {
                            NomeProduto="Café com nutella",
                            Descricao="café com deliciosa cobertura de nutella",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOYl10QNkLEtZZohxCCAW41OOHJk5FW9Tnrml7W-cblL9HzrLmGEjuwZa1h0bhLINyADgfe-m4Uf5w5TpzUl9biMizcGmkBXhcDJEMejowDQFF8jidwLz_fqUPKF85gM4xAGvRg0nLUYyVGFGlh0FOgoJT3Lp3gJwT085oE50YxBN1zmS-TA4xL_Rrrg9h4-77t6Clcg-SEZM9POj84Moj9DV8vmTcKDilrfeW3y_IcGeoqq3xtPyOrmr-9WGLuX6TnUX2rIovMRIByZUtu_K1gCAsTOn4B7XC0o738gtBeuHk0MKReOEXA9sMKFeCAzcGlryXt60ALPcwRhgbhk1k_B9yFKY5NU7YG1I-iHPe4TICmWZE5xQ9DTg3iw-Pd-raqn0yWYoxoCua6b1Cq7tqrTvY96RT6pGCFvEOjcyHSw_XFXeCwwx3lcBgOntTZCeX18-1SKypV_Sc-KT6EC7S9U32shAyH3KnTWjVOyqLd1VZOIzOpB4otfC5G2BhHedbyFffcJ_clVPaeCz5oZuoTnk4UNsO8P5jFbEFrZ6gqPtXT800E3h17F11NaxL7Ntuc2Ryuian81fLrIP7n_jS-tJ9jdEcpO2lU14GSrgT5Iy3jtuEG-gBthIOjv4XI-qtxPY1PA08CYhjRejSTEPYc5yLB6SwlQ5Rur61eNQ_0pXFan62yM8afqReG3q8DDE5dfssPFu8qw2ZbwA5kiIcKBrCtuvqjdtBvXsZJ2dfseIRTBi2RpIzznAjlhlmupqjc357THtuOpvYvVUMoFV1MFOgA_HCiaXJ31oQymqmccIgtzm8lU9y5w7CFjhuX8NiHc1rs7FyB57QQ-0id7zvhJA_x_wqaNDPQdwfFEYGhcXbSD97qF5mBoqv-0ea1nMxeO4i4btNomgNG51A9vakBwtoxYrmd99C3aDh0bXVTzk_eccnR5Tb8u_N56bY-oy-MW5VikhRLFAOCcOQ_DO12sN5iRDjLOCFk9cCxwU6n8WOfDBMQwyC0N8E0lNEWkX0Ji14l0MLucAs4dflC0K94__i77qIT7F2aaQBWVJKmJmJPZBGes3NKoCisqFojmy3FvKUUb3Q5GISIpI22XJe6HWbeoRQ54o4XsRGCUL1CwLmZOcXB2z-saxvh-YwcwDuK6IgMFS2E9JaPhMg8ogWi7z7APc1x-nam_TaS_cWZ5wipawqmmo0N7Q8Iv-7rVL11CcNH1eXqaLchDOYMHVrn4os6ts2iM0hf9uid0Hu4EuzAi9KVNkKrjHiOl99buChGksK9poag5S5YckZqINqPlY-gLKPxWQg3pAMuUcAW22Cv-99fw9v4Kaq4vAn_g96yaU7bnWjdJvm2Jm0Bw_LM0ux06KY9VuHR6GthU-BFHJvGzPbOYp8WmARV7ySyW9Op0KWyna0tVLV2XoRpqsIqvf-KU-E84FIIsMebBAxbXRf0XgzVrhVbSzL_MrWQ1ozqsMMq8eqW7zKfosjWsdzgggNbF9qnA2PreUykUtj9memU0-eBYxTYosp78Ko2EAevrXA=w1227-h860",
                            Preco= 15,
                            CategoriaId= 4
                        },
                            new Produto ()
                        {
                            NomeProduto="Café com chantilly",
                            Descricao="café com deliciosa cobertura de chantilly",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOZf0_Nd24GO3N6r1lcibtUWfHdWbYKN80OyEGOng9dqpU-14X0nOLuVbjuUIzCpnOHQv9fkdBzgqMHSTrCw-gwZQUBEbMwTETO2DyfMsx11BcLxHxFjGqRpAi8u2dzqjQ_ZJ1DMzB6qKKCtkKL2PHJwWZlO23FCv6wBxm_mOYH993ZlBoWTONt029EPHBpz6Nt9CaoirTRkMITTp5thBwBCMP77XeXpxcF1ztKcQmGCwMylUehhZdFWKqmiwzH3JSWZL6B5SSxScVqRxgjMh90u0Dg5k9Dwa-Dz2CYDFdvXAbNKHOZ0PR3qmwcaQE4qiCFWmFARc682XD20EWGbXEpCX4Czz51JUsL1nRMOvqOOBNibtOcI8Oge7FrJSIiqGG0n52Rg8eyEGstxBN-BB766nrQRlQO3xawL-39IDBLTKbwfmQY4dtee73SkduIsmAQt13DvPiJxYxjhtD3rRS4Y3Tu9ibuY7cgLTdSAIs8JwdKKAFXgbzDwsrAkrLm99sGeOMOWmGDWWlBA96UgC2teFpvh13cY-ZMwR4A2V1LmU9CajQ5o5psryk_rU8AMZQ_7e8ZX_npmoE-QxGGMXG55g139M8D3FzBSbbIHNeBmppRYM979Qiz4AhKLGpUdt2QsvM_6-pl6z81rF6sMZAmkl-jyok9-L9V5Br237Y5oRCxaorS6XZv4LT72vavKZy45-T2afklxcekIIh6kVES_iastOIIh1Roq1VsY6zD5gWXGq-eCNNy5p_fReKgvdXbTwgU5vDAJYhj0uHzl5b914SWkuNq2DGECAou4Km3UWfZI3RQDTnYWejbeClaKsbQVG9F916IlFqk-dR05jqBaNUN-ZTYuwT1D3jg-KOz-zTAKi8ZD_066-jNJRJ7JBHnbI_NkYWAyaMwnX7r1oPpO5rPhAaMcChf3qHObtQp1XfYscpoqzG0vQvjKIapmpk9Ch_XuHaDto4y-TVdRa-dLCpEqZ1LeW7X44VDR7fSx78w3RFYAwJN7GlKfig8qcBd1TJHQiczJ4wnoFZRpv0D-crH3Gxxho8LKhMkIsBHr5RvZeFZYHmGY2zqdO-06NIkr5GiGY3Uvt8YEXqGbiSJ5Q_TQK7fcnnsMvlr7wOpG8Iua91um0qw5ebREa_3e7yTM1H41YJtFr-cWaOv9JOVnf1hiY7mWmFCWOjnpQgCcqBQyb_jQhLjLl481IHc8EbzLRuBK6SviJCyEmaLLuxpDeqrwsnA7-Ugtd4EnCoCbXA4WDj-hpCOFc-baocnkyVnULr1f6GWO2GSENNrqYgLKTG2k8udQAbR_qns-duFIBqmeZLUFs3L3WEaFViw2YKVvdx2rUnDDeDR_NYNd0koovHgmM0mhzbzdX-hXW9ydk6cZmqS0Vi7_u05kBmIxlMT9--xfIQhSj0o34Oq6kA8UcOK_YJRGgQwP6bFQP6OmXE_glehofst2bfvSS-zK0gsuGsviGPu5Ql6F8xJ34eGm8xKEnwH5sFRzIRh1B3rlMKBZKYy1qEQlyaysQcrab5hg_A=w1227-h860",
                            Preco= 15,
                            CategoriaId= 4
                        },
                            new Produto ()
                        {
                            NomeProduto="Croissantt",
                            Descricao="Delicioso Croissantt",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EObwfDyvwMEHf-9H7GsDTCViM2cHR6OybXPt6WC4SnFmlW9DGtHDThEfgOkbEqW_tClBZ7BSs7HYDacOA44PeaFpznRcmdoicc7qo7ns9Hng52d2WIbJpsAHSYm68CPWajHJablWvuEkCTfyBSlE8dw2e14NTm9rwPUYNno4g0rz3nS-KtkzKY6inCDI4Quw-S8gWLz03NyOukUkNj_iFcptkp2vfqTM6S5AZy_qLz7b8-CjCIfZZ38QlFh5aGNf6rNxAyUJCLfv5qohfqZFLJui85AuEMJwhEr3lOQ-KRVJy1IabRbQqIsoyK3WodZsuytf0qCkHbMZjnnaa95Ne1n7Rj3_a7AYga5tfFOtp1EWn8GQswgqV4QJpPpj2syWdXXC7P8CtLj9QpCmcLUnYQfGclhE9D4HQwicvU-fHp-mrsy71tWH-vbSAO1HFHVOU9fLVt0IqJ6Q-J9YMZJGz50H1qTtlXR6salQyfTRGi8gENuIZm4iNSA41jmuaMNLTx5zP7HoHVLk__dfaTs-qPekT2XNngqRvKN7dxU6oc3I5pM9dlhWSS5vdXikeUTCZbtTOBvBIsgG9RvXCbB_zTNokiQPM1lHWlkOOyJJLIoGb-BM7oBog95eYuupvI-gYfWGN4dolethOLWlR6Olt8voCJ8sE69-Q42a3Qxe59-MEb95-fm6VJvST66MyNP3JT8Uzbl_JZEp9SDLyGF0B0qAoD2tke0B4Q-ym166AHsaMz_NyCz06KlNReOLQrzqHuny8EE5JD7yhRDDPVPX3IsfZzvWwWPXyY6dnzFxT2raipyX-9hkd226xy-bd6GYRmOSIvvI3VCGQRCVrgV3H2L2fbdDrwCO4y1MPoTG2kXVd9h-t-67qUkiHaQs4ypeSfNSKThZokX5xhBA0pRv89LdqB4LWxpFv30Gf1BKAIvQhmE9wjoRMcTigOhHClegR_f59qeWWpJr4T7m-QrNe2-dvxz9Ipst0CxLiiwZ-nldLH7rGjAJXsWCtxq0hxZpzBESQ637g6z48ZvCNuSgo3CoZjUNUTbvvSCXB10IhIGVa3x5VCXeWCd7oEsxzyY_eL6IY2z3AlxAlrwiio3ZLDKfXClflEh_INGclTRCH6KSPXY6XSyq-Nmu_TCMxKeb-vcJol30Ry4FpXIaRq1kztfyQeulehSoyj-vz8o8D0nInJWTGy6xmwCUD9mWTDEqUTYV7ewiIhbFHfJOJ8u3t8cVHv57mxWmB_15QiiqKdv-BEQarKlu7LvfkIC3V8EAg3I1M_o3whH5hQft06ZYJHRwAVrIuG_JqarpoJ-UZAa_hK70NFkBrmWU_gUNVl8uBbGjSvKY3NqZqi3ajFcgBvJem9rY7jl9ayTQTCtipV7i7enTuOUecx-eSYu5o6paKdZZjMBqMbfT0V7rsyN7uJY0OL-MfmsLxWCOIa5JWyz7toYHgC3KXewRQvR6Bl8Os3TqZHtpzqsBBJHnWfxD0gJc-Bs5gw18WY0iNEbbuSMBZ-2P1UBiCjs2F2JThSUZvi5Xuw=w1227-h860",
                            Preco= 15,
                            CategoriaId= 5
                        },
                            new Produto ()
                        {
                            NomeProduto="Coxinha",
                            Descricao="Deliciosa Coxinha de frango com requeijão",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOYwtLdpxJT49Q8-CMR4Tfmlp88h35-leOeNqTCUluU_kLCh93rxzIf38358ha7caNEX-xPN5GaIix1Lj0IM8E_5HZVdoV2DNetf2ww082TMADKenA_NzIQ6dssL-Q8GCh423jnyOthsGtXGGTzC0WUxsv3GBXQ-B5MWvRTw4dDKH5eFQvBI81_zNXkn1AozAPo8mL68n8vlxpl0aLm2lY5wrjxHMuuJYMlmEXwD_PAKL0yZODaipkfo-uyKcS3ZkQqvhjkKkKNxhYLcHKfGky27OpPcDcIyWMtb2N5QtBbtEWbYyW7zoc7PPXbKBr0oGnPPio-mr_HSQvctmu4wt9635KKHpIfdowdhDsJjTwdVleOx73FWcb9R07BcaFr6BS4rkSKXfEeIFjM1PysvGCXB5HfoSTL5qX65O7abm9ypsDiARV1bbhBVnsoXHUPvD7ygD3lu33bVWVLuOOE7-iOotJKhD-SlLM555lekaP6P6e2JQTo3LwBncqsophYv2JWATMcCXeMxpM6KP43lcfnV4ahZLboBxJog3ccWnqIK5EuXVu6K4XYD4eKWr4F0is0I7EQEy18IYEri2Euu5ktRgrvGeDmIiw1CI28ya2JBG_qSDgPnvSJZcJhR_StOChcx18RHnbX2Vb-ORqFT7JKb0E4khxqVwDVptNwF8NlMpWmUUzCCI3_3zaP80quoBQ26iFqPKhkTCuqFSjWmxcsAnkIx0DZj-RktlH8C4CnPpsxLPpHIvwEmhOrUZxRdZwzHE7YG8Sp-2A9sbMlzDAE8n40f2InNyTPyhDpWbYLvuenipkU5gvMW0pNSbJWFiTv6b1qpOCdSM3NUuhvmV_l_eaY4xX7psi6DlFFgyQ2dXk8a4g3EuAcNNNfOU0-fU5mPxkDztPrXdSp-BILja9hId8Ukf4Z1W0Kfi5kGW7RiKOQJS9sUTRqDExydPvUvOzFx_ozbZncVBrglutmjmFcFqSJJP5-fvQvbHytg1BvNmnTnqH_N_lVj9y1_cYsEymEmnmDgz0Lyqxn-KI2qf6fERaNh-Lqvo8wO4eDjD5bhcYtHp_Soy6W7clNog2HroEFMA7ni1D7108meJPOsEe161e_PDmUpOXMvKrvoIpPVkHyYaMBEnf9xPuiY5sEkNL8-L02YAaSbtfLKUz4ym-p98SPDxLzCV0oM5n-3eFdz8nK06DYz8KlOY3QqxIVoeZVUs9QKtI7GC3ZjUSCBlhxJu4A26Eyp9qa2FWjyKvRU3C4QFUu_VMnUWXjFYRku3Or2FFuswi4tcY016TAS_cZ07hDor9H08f8YJM9MWUQ3kocjjTnHUSaviMb2TSlFw3T9KvgNZbhcBcPVHmoaIS0LkJIuXjF9Y5h5Lc6Rvot3PL0lGVf_JU8tnvvgJf3uCaTd1V60tx6QpmcMt6IyYWnoYX2xghJOWM7zG92HfOJ_ga9boXeB6whWyCXevSyQ5wvtmV30uwUm41Yy8j6ho_AWDmCWdSgJqZO4Wm0FIu-hbj-YbtDVNVYsHs9A0Pet_N2LMA=w1227-h860",
                            Preco= 10,
                            CategoriaId= 5
                        },
                            new Produto ()
                        {
                            NomeProduto="Pão de Queijo",
                            Descricao="Delicioso Pão de Queijo",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EObQWbz8HEVLHY9oUiPitNPL8ELXAs712wqoKdT9XLTeyJa1l6XWs1kWzVGVH8CTCMOpyMuYQlzZXEu66gIeGvYMJT9PLmoWnLv_aYuY0Do8TizMtcW4UvYfQ4Xie5Vg6A6IRxuyJ2hVqcD-ZuHotgHOO0gUF-RbsFodml5pev4bgxMr5jObodisVghuqptKM46QZlnYseZtdIXoepo5okyqJe09fYFay6AhZ4KGma0GKXB6hPbQgYDQ-Xtgig5FyTkHs7OWxmf6kjww99Y6I7mETdbPZfIn-Z7rqRAx1rg-KqJIu8kBFUPMloIspI64FN0YAMjDNxNnx3LT5LhJPav1e6A8yVyM_WOUNed9X-rC-mXbPHOiTJSPF2CmPvPEh98uTEeDaThUm5TeSk6B9uZ00ubT5sNLIyh1oHTY5J4FhON4C8L0BZF-eVh_CY4qSqTN8AcdIq7AQ9jBCehPtF8kfha38ZGV0h6DyDe7h3SG-OTnaabVK2Xwt_Zbb_AxuqDfMu06tCd2GAz03ROrMl029q-ozsWJ-cfWaAI3uLVCq9kYccYEcwTvdEBznG1QfK3y0lDo-TOMmSvhq8QfKNCgm-K8X47lBTfJu9VCmOUIlXIJmSL1BbBR0TE1S7e6liNzncrAj3glRsanyDN9bLeBP0Xshu_v_p8xz9kfNmWQ0m2ByQYxjHWXEJFYuMuFU9qwuGeBUxBUKQnBHEiOKC_Tf0B6eqHvlda4JjyjbnhV7K9aineOWQ54StEHEvwK_pRw74MOWU4x00CJjJsF0_IirpIwwbrtZwoG8oS5RSin4mn1NOvgOUv9KwgS-ZIoZLvaSUS_nZeQyBtiLA1lcAgvm7ZpBF0voDzox3crskp2573I7Rti5nXfT83GwvR50npl0a-fZgKbYIjTYrlffQYpd879VXr4XPpvwjQO4J55wi5XN6HHirlktc3WDXcrAJBjAADUTQia0Y6tqA2jWbQXu8pPu_jd6IsF2STqkZad9h-Z_VyZPjTsm6ts7MhZhLYPuWmYYJMwlbcxC5pG-IWsDnEqk35uwyJIr76nXusWC_OOIqcbQ0kqYcD3AdrtEN1787eoUgTMAs0teSGr4k9iMyMyvByHPFzGdq0kbqKt99iPdOgC0SVQJy93gx9p_EmoRxDuPhb90bASD32rFRSlN2cIDIuQYHWrk2tJlLJ3vzvbJ4LMX8IpewSHoILNqeZYcwvUKmdnuuIbadvOTrQNHH_r3fXXOfs8MN77IpjuJNUe-cIbrS17qOvEDm5NSi4-ImIJKJDk1CrAPivM23ZiSiwldvlnFFL3kOEdmcwk0JRYcqwiefR7jzXlXdeiJLCPbjG67eQYLU29QQMP6KOnmtTN6iCKsrIvi9wD-6AK13G9mOs4JLDq2VDxudH6Uz-hRLvS5z6oqfkbn_sYG6YbylChPs2OrSvCPAGpVR_dv08oIj6GMM3f5tPvWskEEiWItgEKep7WfgNKMN3O2Tb-HTKhhqXMzjxLmKsfztwaWoC2YWBDJZN5zdYjsip2WpYvng=w1227-h860",
                            Preco= 8,
                            CategoriaId= 5
                        },
                            new Produto ()
                        {
                            NomeProduto="Misto Quente",
                            Descricao="Delicioso Misto Quente",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EObDT29k4e1_vGMN4Ep2v8_I68pWiwWPYHaqfnY9sfPD1ATve7GGQXN8rHgPtRf-OWeuBYVF4EDap0lcPHrF9wZhzAyT2JyHNrREttWcxBvOktLgqSG6dapNTWNbPaHVO8N5wwk7-XHCWQvthxOfS28UAUB1B9p-QSD67JMH47PeRUH_WNgCuhCJLan0T7Zg9IE5fypgA4uIEETW1Dlp9E8FDblUTzX8kU__sFiSZw6-nA8NCdU16l3-FSlbMBTtSDovH6Fal6klbjuaGT7TCjyeE2FvIhoI_6HbtopXb2vN01v9ffnXI3Xn3cEg6YBfYgMMXPDp9y2lM3skCULVKROVj_R07lHByZBb4kouFgmq0bfk5LgvAvg4S2IP3P_tev93BQsII-a8UBUDbDZKV8AvdQ-ke_YlMThx0sq3q_os8lRkJJUOEcRBMq4xFOuE9tU203-fqz5Omuy1QHjy0KrBJvb8lIySMTDL3TKO5mM0DH-cUZEXvYx7_VJP9IfOmOb-fOkkPORyS5SL4sLPIzo5y3b7ABmeJq3UlvheYvGALqlY3GUxWN00RfCLcodKsFjoZm14W5zo8Dl12Ej387QAWEtGEFtI0dkNNb-z6qFrdLPyF7nZZiXLqFPySjU_BDQGlTutwdwgJCTlDvuw0Z_F1KKKS8Fc0O2MJ5RV1ITR7IlHofoBPU2L0bud7_FnPBr1ROVP37xqgsHhuKjQF-TSFtNakC_3LAauxosa2d6NIXUrb1Um4A1y3ne8yclyjF_f8jA_lBXHUfgkdlcxLnGbJ0PnV_hwPAL4WS-YNygj2x3ElL1wcZZY6kphkoSy63oMcjTDdN1uSmt6vLBY98IsKHuZfn2fderKQpD4XPyYUsHueqcm9IIQ9KZJTin2z-RQ-GHHgkeFFSw40gFyOhk_m95YQiIfAa9YUX637qSz9kNo_aMFfOXyNsERnUAqzkGyQTuehYjlIqFMw80KRr0UnQs-n4k_TwtqcLi0Lq5CIOS5GQgsbBjnJM_ZqU9kF10WehSmx4_aDsSm856x1MMKV9bzgtZaZZBPF4m74jyOJhUYeO25u1MTD7JsPk16iUVDIAEjuNoH_exHXCXZrr3w8z_KYvxXMa5YclvCsbNQQlU8ZaxjXdeMXzoxqHQOfnNIhRl_GPnSg9tXEMqY0I8ysl3Ke7PvpxV1K6CSLYgdYZc0fy-PL_bAFKJro144n6nDyogEDPSGI31MnK8jzV8cRmuYFYsNjrv5MbkV53lzPjijqOVv7UtCn8KGvrSJASOiooyE44qc4x7EuHu4KCinu7Ul4VA4g4kSd_-4fz4yKpshovRJlOiV-CxbKvQoABuXchYT-g7y-97-o0zOgCK8o09XB_QPQq4V7o8EgphAr_MmzhlmHlm_3QY7grA9UunJMpqZ6kbclYrP20PbG727vYJo2u2g3d-zrP-85Jgq5u5mGsQ-s74gCyfhndLJlj8F5ssESpCLQoxd2glSf9eYQ7vAyoeeCjByjby3aXwaMLZ0DHBDsZSWzu578CEDwmD9KQ=w1227-h860",
                            Preco= 18,
                            CategoriaId= 5
                        },
                            new Produto ()
                        {
                            NomeProduto="Pastel de Forno",
                            Descricao="Delicioso Pastel de Forno de frango",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOZvKiXYdyQrjvH9j-P2CRCHsDmbupO4yDjC-ZvEjlBAe3kHj8tA_WSrmW11oWx3-E1PgWVz2N92B3qmTqnDdHoIWuYg0IFSbUym8IPNmtGm2JVzpOyWXwlhdisGr8-a-hABPq3oh2zQai_AbudDS-KMIoknFjhCEpz8EZnCGMoEIaoTFcLk4LXPfunDHAy3cFl221xU4k7D1cINThsr5lJvl2A30EqW8OlFnWs5gTv9rYZ59Uw2mg12sNnXLzd4K6bwk7q-eqrMHG_Gu41MQq3qHXbiV5N7hbeWNMCq2x3U-3c3UPKpvyhALbJlG5CMXC-Nsvv_ycZczXX_eV9MfrDLcQ-KvPsJ4H6kN1XyXJ7tQ-MzAycTtQU6YErFzXnlCpn5tQ0PDdTEFnw-vYHkuFIWRyYv8vTwNDKmPdWbAB1Qx1dKiM-l-D1wYszrME5xGIiNfFh5jvS_MYv1iUD1-KTPm0jcujK_977Job7Z9oZRPFjG88Riikev6HZDxd7Vdy6kx6L6HleUWEabUCJFULvDyb5-uC6BGLy-EPgOkQvRbVsioQXmjCjfqH8gKW3ux1fzbrrzvirNa1_ZcIFiS21U1GtlhyyxDLC4ExoLq8nsNRgpI8onPdARZN5wNz0as5GUv6ZYZm5gI41J1lwl-z11Gb0VWckOxtYahnWF8HxFydnpGlIGLUDZEa35zLnDNPJ3YX4cvjEbO95FjEfaKWIGTrmcpJ1gywVeQK83t0UPcw1wRVFKHnOEo-FBALqbWEkVAAZG8yBn7dwdZavqxnCtkIPUwBDCbIRDF70m8AN-t5kwoUrLPJbwBHpcQ0d9XNCOF-50sImk9a4Vwy2Tfur6y_p_xSvgnaGyi9DKP8BvMlQkeaRSGyywt4CESfSphxbeuQ8oPR7WPdM513VKzJQ-FnTb_UI3pqltjZiYt1Y2VIkeXSKHj8VQ2LKt6p9wm9mh71y9aUruczrFYc6kSuF3I5omcu7iW8UqwiXQphZABh_fxkBOzfEvVHOvsFEB_72fWrMF3lzskZU5cgfX4yY7jt6-Tw4cEJTAmvoc7U8eZ07mdLzBXTnRX7L1V5YQHvzXftc2xjbllbRUpVgRI_U_BZc29bElA_sJVGy7HQ0F9aYQnqgH08wgAuMDQ8F3ClksHJTmzKsZIXd4S-4Yz1PyU9UQbkl50NXRTUkThW7EIBtdjLIQZYqudpsasUU2T93ecA01SVe2EPnkm1PgpPNmZnfs1FE8LUT9L1MEeuyikh9bF0S9qcAaBowtJX66QXhU0TjXYk8On13au5g69jTI4RS7gUniEQYWaHOfFQb9oRZUUfGv_IaiSILXuBj7aFxrKnhDxwaK7ys81eS4JqHvtAELuYYSGrWaWg54DUQFe30VLd0c-DRCUZJ8ZkE5QZt_WNyG8DcDrGnEkqFwD995ZnmFIU-_7s7AMlqK430bjvvBZaPQXc5qCmpF3UgIbp0x9kM-7NX9lh3dHCwgvbcF2vKO_35uOvh_5yY0AxOh0rIC5UCgboUW5EvJeu9M-zJtQg=w1227-h860",
                            Preco= 17,
                            CategoriaId= 5
                        },
                            new Produto ()
                        {
                            NomeProduto="Salada de Legumes",
                            Descricao="Deliciosa Salada de Legumes fresco",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOb7DZiBZhbIm1VCJY6bUasLnbtTpB--65P6AAzdZRZBV-1f_cZuhnQp40SZqPaBwnaTxz_Trm5YYMTHzh7aqhv0IISDA0MqpnT4XI4bw9447Uy-pntk9kS-zABhiQ_DIO63UjoS7c3ft50KWglVeGw5kuvi7bpPVKEd9IxXkM6YgXWioswzuxkZdsqJuZwkGWWk7RQgXJ4WL4UHTjZXSY4sEtWX_EkFoRXWK1NptEYp50IgdEYWauUU9nYOhxCzXlLLctMJroIJkaqX1KWXb8jBSzadij3gTKRnrydRq9GhIi_bx-u5ghipAT9oGu13skUXj7HKgYQOMHE4TK7Ryyq9X0FLHzjjBba5OKh1oEiWXP88dtua2SNABAbLO0R1iGL7GqVCfnN3kNqb9N2UNJMAeBuTSR_Ig619W1CVl7Kl6ws4qnVJeDckPKc0xEOGXblNwMN_JJ_9f171FiH9TQYs8ki1PpGa9imefPvM1W5G32dKKOHTy5jRYsrucmJIezW7YK-ZfbopSLBUdAKjLhOqCFf3H2ZflU5KVPJw2y1BqhacoCIXDjx-U2Xp4Bgbdd6u9J1NGiIPHbsq1Wwyl83czPv48oBIpWXhX1KW7icrPutznBEUCbyx6nCXhXpxySO3HmJsHftQG6Nbg7Gt9bIJzKoPhOhcY_2_fzZztBe97xdqQPG5TvTvk6dzHhrTVNRFHZf93axhFVwpEj8TzdE3wsWF-OCYT2HiRxT8TLauLEsOwKNo9hgEvexJ_HgDtz-vkQPoHHPrOF3G-MgNXOsrAzhPYd3xANcZkhysqJOKCtw3oII32YJJFIvNN1mESPvCoHhNP50ooYCWxE_AH-hm4Hu4LoJAwHxvApQuSpRqsh8eDBieZjBC_dhqYcKJrB7FJQcpuMABsn1r8CLXx8AAS-vPgIvQSaJGeKBfwhu5oI-kNkXJOs_DiiJfvwj7RrAR-OQU-eB8INEavBTvMAKNnoNbju88j_CJj0-jB3umkCe0RxUlNoeh_oqjlSj0t7uFMyP66KGBSb0RbHSXgzzht6iNwiv0dRIeBcms9ioFlCGl-1I0yaLrJwlQ_pANNJdLWXH-HW0DOKPMjIid2ze4-e1_ihc0b5FTid6bfOZ7JBi5h1FbdtoN-8VSH4QIrOdQbQ0aZ2VysDowZmRhaecf1mcAiAhmKw9oE-OImm-ljqT751pWeADmqqPvXtRX4-dMDejmuDi-gT9sR__5bEv-MoI3rQQw3IZZxHvGHMix_mTqAMkJPC3a00m-N74W63ylp-cuOpkcepAcmWRc2M3bQxumCQzu81RvH875yd9nZbeHiRYgylxUmSVWcetM6P4gh1Hr3BOdc8JtfAQgy5M3GD63TYym8yqxQyAN_MxHW-WYwHG2K4xCwLhdtIWPXgW0-wZumf6dL_fpOwFyLTSlx845l_roOWRmWFBldy107aDrQoVH6Hho5u0bP0L0kLXx5ym4OnWdKQHEMhF8zUQfJFpkdVDOjn1oGuIatby8OAMey9lvGd_po43bKpQCVQ67fw=w1227-h860",
                            Preco= 30,
                            CategoriaId= 6
                        },
                            new Produto ()
                        {
                            NomeProduto="Salada de Frango",
                            Descricao="Deliciosa Salada de frango com legumes",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOaBeIIKMbDQobxj4FCAK-7Pr_AnLy35XzrgFAXHql1G35c2wvC7aFFiAo8qbPFicOkpNvzqBF0kTlAeSJm8ngYkoWGOxHOdJYrrr11pmdrtWX8WcByYjEbHGDwNZ3TDQ-6SGv7XKhDAOu8oYNSKxVBJxUn1ebRKuIQPZe92efePT9AaU2noq0CEPNbNpCHTT-owmsh7cA3vrpEXIkMDCag970JIfTvcDyN6KIZN0MBaxo-xI3e4EOle6DAXtmVOZvA98Xr-Mo6qJeeIK9gTk3ZqxRdxE19NzVmiTR4WjKc45sZOpz-J2s5UBsYfKXU1XF8tg6I9282Z91eG_4Sok9a3caMLjpnvq5z00lSOL1LYtIVaiVqu11qgCnPDtTrS7j7SCQA-6txm09owaLD-FODdJP6ltZW3ZDE2Jz4vKiOY3rLvWl_s2GlFWpIvepskidxvTh63SMtLDaVkUxx2E10Q7Mv563TiDEF_i0dugq0JjngITQmalzMxF55N--9hUNJ5low0JfsqtbSa2_rZNQa_1ysw6G6XEAvg7abX9PTajl0zRxD0rUjlq3n57Af6FBpPn3mQhGKhvMjx6uzIeG4ABiHqIYD_HErc624YBc5EEjfxDQ6Sx36bgPC5q4mdA7OfZPOWc4c430tylsMrMrhJ9FrOXOG57wVWk9JFchVgNLlllbgI3cXVQG-wHk6QXagDfmZwOJ0XkSvNLHOhUYf0ABZPrgiJrCKDlA8XfxvJ8d8qY8iEHEfHb4XCYVJJ_KKz0nYWrE1Oum61Tbl3BHtMfu_XzdLHdhujAosXnoH5Z7GKKo5q4Q6YwE3jTXMXtISa3VFMirEaCiicad2Mcip-6fp9yOtCvOHakf5kZ80nQASR6-KUMTbN3_5G0dlzPX8o_rb6_0dGh1RBYxwDBVLcnQ1qPy2ziicKG8PJWzNJIqxEP3CLhCkCPZR-8017KLUDScIpE_-VHqX_bByNb8PZYbzcxrasG3F0tJ6JDBFM2RCuj_yJZt5cSlPwKKtcgolAnsfidPSXa_D3DyWI9cw5sB23RdmcoerWINudCbgQqDVuqzb2a21mpdlCX7h8pPCITt_gTPLr3q7jbcOztsD-Ih8LUeyp-R2C6NCpF6XGVxZGsg_aWgmfsjP1OIohtHsZVrksuQzjrMYrSQ0JGwmG_EuNWcSFkfe8lxRuM5LvRTJgd5aLsa6bbTUy2fUcLwGtyxUzTe9ILt8lByxXSkzO3tX6WSjJZ9ob-wfwUxl3owhh_IjuLAL6FzlwJvu-qDQ8qYk9e3BWt2rX49Rc2Z0kDDrV2VHCJcUrgUYse0eOPKH0exiY2sVMDCP1YYRIWiscnknxqiNnpx46n0uBdhqB346_p1C7yPTJQgbMZIeDkI2GbBJUhQCGfWp_Rn5nFiN5FILNfUpn4jqqD-jrbySkOUmg1uwE8xyCKXSNgn3NUQ_PL_yVhbrLwicAdNiqoWLe8ZQvLeXkjJLf5vYrw-NWHqGfbQouAmaD9q3BRBzntfKRlJz-vP8mC09vS5MUpdMMVA=w1227-h860",
                            Preco= 38,
                            CategoriaId= 6
                        },
                            new Produto ()
                        {
                            NomeProduto="Salada de Rucula com manga",
                            Descricao="Deliciosa Salada de Rucula com manga",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EObuyDqNBtKxM3XGbNaYthqyPzYbefa-p-m8ZGG03VHn36AYim7LlJdG8zMjTOQwUP7AqP4NLT7IHLYiYi0RbPqSf9Ocva1Vi7146Ls7B5lp-sEJlYrzJpn43c6nm3uONejC6fxqq8mrePdEiYmZqhP2TY8Do-F35r6QUWao3ljQ3BLrm2w1LnVJtxlfL4t-bX_WbfhYLdRk6gb7wFizWPfW0Q1kVWqT-Q_E1w3VvsjDarAkO53BFe8DGcoqG_UqOUDhp1KmVE83OndjV36UnPZUUsDxHipQzNuu7LMfmA6XN_cNvydy2oVrOo6DQEFp2uEn78XAXTMaJetSeg69xXXcDEO0F1yy0GUdYh8YbYIijAbuYBdYHe6tOKcFgUboZuLGXgLbxhTwOvYruF_DPfP9bP7AKkloWlDGNLIBDU-s8PjdQnolWJcc4F5VMee2_H9A-JIGdcFZMF6ZtpSkp_nBpyne7_5T3ZLeBaPEfxAnznLEBTtZNYckbHkSRzIB4Exrm6pOhNDUaY62swBZStymy4I7G1lw5d2Lsr-VdKaFD-G45RCwVh6eljRHol14C4gYsgWcAfRSXWABsKQqP-jrM6iY821lCw5ZHpFerchxXIck7if2MI9n0M1xfew8ryFo-VSSnq2sZDsydKRaZd8sqfjUNUqrsu6HsGs_1-pJ9mioHLxlZiKNcQWZm9TOovEJmybOrFPI2htJM3pA0EoA39VEVRwATbbPCSa9Kw0atUEwV6Ttw558UTREVqBYpJQN5TOgUiUmTIA4hZxXDeDQ71rEGOqtfOWm9aTrqgIj3f1hTBBRhCa7R2vL4nTLVdKIYuxHFMIeYHeNPGLAFajuMg1iiJs-S-9XqRaUM64EkMWSTY7LcbZsDYE-cKiwN-vUmft8d4WlzCxgqXZVYwHxm08ovI9FZTtJGOua-oT2F_m2a_crK4W4v54EF3re_RXV99n7Esg66C-xgMQ1oYQxj2yVMuIBhrlPXl-KIIDn8jCHQTiv9PSSKeYFQqdEG4a_2_J7zzOyqSFTXgD7QCWRCedBuJWTeczJzlONw7KKVhbqoAvf4Wm8uuAqqDcdmdGiH4WWPQG6FbiNjdfDnVSdvf7F2L7a0OwNofDk-p8qD6z0k7TWjpW_QOIhJt6UDFimb3OfdX9f3IRRhnzBuiXwXxcP4-a8s3Yyay2LZZ8TjebVPD8BdF-arcI-JxiIH4-9zMnICFI97YIEGInqSqqZAEaX7VGDJC4ixmOADF_jU7eBt246z1T6Tz7aBkiGclbduGDSwVUIg6nV5arLk1zUMRhnFvDDcuqHyDD-rAfgxJepuSySh9S-v5lBozqtGmEuDBciJf_iBoqeo7VpCImFLczWnZGI30s1pOISVscRhzy6H7aAVY59K5VWirlgj--zd7bwwmj279ptXITJJj7nxwMX0JvUVjLekcJzipCthdtJr0ueHhernPOTjeoDYfXLoAPle6wheW5q1e-CfPqEr_uwuH57aFGzytHBBlJOCHioPhUby-IJFClcq8xv8L0oKA=w1227-h860",
                            Preco= 36,
                            CategoriaId= 6
                        },
                            new Produto ()
                        {
                            NomeProduto="Salada de Palmito",
                            Descricao="Deliciosa Salada de palmito",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOYxVze90qKWeVFA-Tfxcos8VrpZU0Y3m3Bexym7QW5HrZPs-FMxFLwg84tDLJ2xLu0Mo-3yPAm89YacxzKAi_wEpHPViVhFhvmb93LxWA7xibt9d633HRh1EpEKWaC9Ujpmu66FKdP1AOSVVpdh-zI7cSpOFcoYBfq39S318HxOeNWXaDLWk9q58I5FNdXChJs-tQXiOEabVySfaSsQtm7HLhTyq3IKJwT8es2C-chEL_WsoQKGH5kpF8Q8C0DzE04REUUlFdbAlW5avIHzCud4CH-bAc7yd2g3WiEONVdr9RwR_Z1qkKSbfPC_Xkhi5eEg8TyliEtKDC5qo9AT8OTqNLZnOhnVcuzGIXLvke4dtjzDHI7rM77PptCsY9CGGEMw6oimTk9BtDs8mbBK6p0GHZnxn-UoOsC7k5LUaDHQoUVBftiYFhS2gTDTZ-pkXf-NmAynyKbqSn8KKNhaXl3ofqySC8etrafvgT1XjhAMhBHKWoAP3LS3dIUkEm0bNLc2dymiaD7T1F6h32I0yzzdAovQnSHaj3oZVFbR6-_nGalHOvIjCTR4mm_tvabQwVC0FPe0lKHVMZJDwYh3URzIBuludgBqyQkrrTN7EzUFUyXjTo7GwF4s9zAbuC8Um_jkYikHBgHHAMpq6y1ml2am_QDCblxW_qc-qGbUTLxuhDsHD_UtUfLdoPfWJsD8Iu2THvM4QqMUOIasy956udAFNIUOLtSstO4iRW-sko7ACrtQ5KcthwmJ94xJWNPuC9YJ9NAFAW57SIkL9rGee2w9r41_R8lxqjujefGZXYHWGjxIFRQ_r7tRN-_97FTyTY3ZVteoOt02wHig6IU-4Ew5w7IMEEKPDxMechuEELGs42l1o6gn6V0CglO1uU30FflNG-stA8C_hbQGV3zh84RMESmJFFl-5OY1nrxsL7exGzz5YaH79YpEKux0SqmkO4rwm97SjVNEaX-HhVkZnoInLq3WZxcxCs76Axz4f3NqMu8OnRNW09QJezY6-bFAZy7I-doIXNU-CzP1ed4fKU-QqstlrlmH972pBFJQmLhMoqlJhxPRjstBsAn2JsE27As-EwfDOY0eY1y27fZUNhJMwBgoJoobv4hXxoVl4TPunCXKPgVjvc7Kvl2a7gNV4j6rwwaBgbla_aKV05BgqDsQVeZyQh_vX4OpRoKJiIGFzHE7C6OsTUzz7c85bjb6J3cZztP1LwTbusIS2qlCclPn1gp_QWcBbTAVpMpEHMt5wzP-xFgkThHcOg4BJxawGBUSJ_qB0epC8wkWQKgySVLScrtgBDMpKaDyjPaH1thGiBenaHLdt44R3e-ADSVJGhtMZKjViUX1_LSgL-gyK2-WOCHzdx2-8ZCfzqFsAjdCLp8cq7eSpTaGvqSye6YJn2xY-NGp-RoYHYQtKufJroU45iBLNPRL8wVJg72J9cyAdVvaZe4e8NY9tNiKPgdIBYgAe1BukkFxTsykM7RbpIN_4AAFZOC9c1w1e3HdT4Gb9pSVjVYkhYRRRitmBQfdHBUKdQ=w1227-h860",
                            Preco= 32,
                            CategoriaId= 6
                        },
                            new Produto ()
                        {
                            NomeProduto="Pernil de porco",
                            Descricao="Delicioso Pernil de porco assado na brasa com farofa",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOaxvFRmZfuTgL3Zr8Bikmju6XDNqfHptQ4QpJtsVnM5tuSSxLrtdZeGHX0JG0XRjlrhmRSFOcGp015NU2n4GnIo70urTma6LRJz-ImAxEvMqfqlayQmFjEEoLijgARcXsWK97RKiI4ib4ttk3rSRyjqEwvCvnCwZc8abzOF8nlsQClxnfK8cw9W83wq0WH5t7iHyPzWtvqMIJCQRQL5qa35dJewaUK8i2sKM-gXzzj-1lfgM8nhVw3OWFezVDc4R_U3pCr4NZY2bDEhER0-74wkqufm14lBQYbGdpkPDp6FqpKc3EsV1lodvzmdOKbTAOQlMx1mEUcfRjRaDhEytJ3XOovEmyrOUI7QIuTQ39AK66aWe8eRRKFG6ZrmG31N46CAhzoniLnha8IkcEUdVMViPCmNjMa6MnSCs7G0Vw2jRgARNI87ToAYu1vXKzZt7wDeF9fRQeEEENajOm89vm-hZib1V1Ud_BOY9x87kJRM0H1zjrvuIMuLJTJpMtuz6uZJ-EoI57RKsuECwBqNzXHWgNz6Q1TItk-UfcKwXhKYvyxUOLQ9FFQKFr3af57djdfhWey0-6d4D-xkr4Gxw4CwI5feg_p1efsvDwHzHW-vJIsH1pSH4aCkrai1ep_GaQHu8JspILBxpIKzY5zAqKx_b2pQ0ga203JoJhxc0ZfDF2U4tRbZMagyGWHflJQ7mtjEu-lQ-GoRT05aAViSN4l-hTTrIETrmk0FeRKhyoB_a2ZHmkciBA5yHej1m6BOqkG0LI7rYfBqFCfgKjVYffm_rzipavw1xMVpjEo9MS7MjTPHHYA4wJOVYEhJuiZr_8DPIh43V8MBz_EghplzCLaXxvU1w2QzWcAZBDAR71Vv-PU1akjk93Mhfx2ZpjovHF1TrFVqAvOJkb77G-zIXzIDQtaM8nspPkD-IWNbiX_Y4yR7jjSu-DGGjSLodW1eCniFSrqPbKoUx_jTDCLyx0-WDwFeaMsDTcKXSD4yAlAsqtaLtDiKOllx6JUL52kft8XJAmG4zUPaFyoPonG-QzErlMpMWbYZ_bA6JeemvH5HGiM8dEwFiRhyPp4sJ4jmahuGT0yfNRuYIX3wM-3UGLZl9HAnuLjK11CxMY8O8RK5LDFnRR__tDMW0GYJJ5aji7xNlgQy0xrFFNMTkbBHK-jdxuqZgZ-x-3JkLsYq4pcl80RsERu7JDvj7-qon2eijJHVPaBYbBB5WdiJja6gCM8xRJk2LmqS-mEsxafE3-1Jxq64X_BdtSyrKwShw_VV6lfByn4rxCL5GLoDS0KZ2VXQxYKN5Oy34Fp6kHmHauJThX3mrugwh08hMFNro6E3_y2znBE3YXmVxAwjDtu4qa27jSBW1tqzYzkfsi-NVS-hcv2qEvd4WXKwbERPe-qVWVn3sYxv52YG4aGV8KRzHwyrOYleVZRYGG90qmqkM3eUjuYh55qUchHWmkIngYTDykD9vKQ_G0IbONeg58Zr7EGE1ZY17jKPjqJfCJyFyNvTgithD8hKimTMbB6DHz5TQY2IRw=w1227-h860",
                            Preco= 45,
                            CategoriaId= 7
                        },
                            new Produto ()
                        {
                            NomeProduto="Costela de porco",
                            Descricao="Delicioso Costela de porco assado na brasa com farofa",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EObOBL7dQDyj9QXGciv6Oe0g4RLDStSuJaeiYlEBUsXuRIyLW8JsLDzj18qDfgowuBZNVLjxR_EFs9pGeHThu-n2WVZO1pKSWc8WT7MJ6AnA4z2nrEFED0jamflOVPjh1OQRLiIzBYosIdZbaHapNLaxcRbmCmMEqejiY40Dl9tRIBBcT7gIgbXLan7OCVJiKJpkn_EFpWPL8v6FHYEqpmeBdiCOkS8HqJOWtEa29mBlWFjg7oOM_krlSBb2_00-3r58tOIoD-YpIC876DCFWMcv9l3zzwNpAjsZ7B72GPHZHrGfhh3RxYZvBqY3nUqvkG5ADb9tL6i895ZB_PgX7iJ63xCD7PIsMYtK5KcPfnbUitPiCCrpZvE--zZk_lobX8y4PcGyR5r3bcixQvaXpC9idgu3W5f10WeCvwt_KDGh2Kh6-KEmuGxU9bzgGx0zs6QKtAdlSPM5Ce0wPTlZJydio5YHZBDJ0SRLbZCyE8eIQ8roSDbj2JqttvkCOUNJF2Mgqm0s9gkJdy24ggpQPX3QTdU0aUMDGlHngyseQuv_y-NJWgqbRKhLGmad418I0eBUuxiD1SCUNQGOendOOvY9kCTARdjWe7e5kwYiYKTECAajYwTXrBCkS_Oy2wsz5lgZ9nA08raZ0sF1eWAZPeH4DjRkyFOQsC9L1s2hfBXb4Wuqm54nyDS48_i-DwkJATjmCTWE9nJK2sKagBARcemxXil3XCydfKpa9dUMLqa-SFQFdzQwSyjZ81KF9JkD2bD0RcO0rRoWUTs_xOX5nD-VFtR4xd-2KcU6qEJ8ZWdoP2Am1MK14VPttVxXgUjOaynRAMVfwpFOAg19wxMkaodaSI_eOKhcCHXigSLEw2F27zFfzRbxg6meI4coDDvfdhrKJoed2bCslFGW4YvTApD8pWWe11S2XLiNUa_ur96J7qVQ20b6NkurRZ0Rk01J2cGKBrzJ-ONG54MB37N0U2o89EMIr9M7s35AcRTH6x8_nY1P3gW6EndK7Tcvi7kKPlKbYq1S-p-W_szIBj793mpeNTs5cTHUg4uhCLwUAfFB0eWdmkaJB_kEkLobHWb-gxElS_FA_LCIgwuXYQ-m8sw-r9D5oHQ2XR1cVxA0CBmoEQbrDvLAxEQtFgIySVTGrnXXkaH63Cao0_CgHTX5JvM4Gp71H3A1EMDAwY7QlVHICHm204MefIyBji0ZpjEvOL3cD_CxYg4vsm5u4mnAgnGSdii4_TgqJPj-ZvbIxTVlha8MPkKH7KalwkiIXDgSZGAK1uDxMuRJb7yx3gdtGe9i7VdY4QHV4iITYJtxH-ulXWl872HW1PV9LZBlPaMH64gEZi0s917Ue37NG8_jtn3mOH6qlDz_tXmzvW2EhpFcT7-aTuetGzb8EQFR2IfYpKb4vNiJtvZ-bjiT6G3DokfzYU6N0sGQdds2Ocw0mF7rh0NT5JWSqm_B1eiJUNfjB7KaxrvnfqOA92oxR7flMN0FMOCOaJPOXb_yZFdRBQoyuI5LAEZxLIgI1bG7g3CBIz0MBg=w1227-h860",
                            Preco= 42,
                            CategoriaId= 7
                        },
                            new Produto ()
                        {
                            NomeProduto="Linguiça de porco",
                            Descricao="Deliciosa Linguiça de porco assado na brasa com farofa",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOauF5bk_UYF8IwoUr5CMJiO_VElZKLySoBE73AIb44sWMG0PUr5f9iW0UwzBqP250asrAyuyekE1PwVRpPa90wwdvfkt6ozEQpQ1v_DQRgz0niFwh3V7xH_p87D9pJSViXKoXi6r9bP11m3jpTSx9crQU0NAyFXrhUGva2qPd5dWkqG5ZsT6rbNQu6nGAcWdoVz_YJTmP1dJD93BuZ-I1BzVoWHQmCb_XAbVEINmFUgvQ56dMJOHFaYTwbhhbFz0I260LruFDjROqxSpz7FTCzM0o10l4VK6Ndy4LwOhhAJTIypBw_aSzv8fy3U625QQgfvxf6ZjuglDgQF1Zf_aUhGa08hLXTK1NDZwWOtH1XliREWZEUB_ipgmbSbFBP1lMgrqryFwiDS6vWPHcpH2IPJbX4WG5TekmhxkxWrrBofH40jRuRN3rIY0_KyjM2x6rwdc_5ZvVT3TNKiisXa-o1IZ_cuqfR_O6Jm4Wigozta_ulH6PuS-z52J-s725XDuMge2RM2WF7YjAMPwLKlObOfIMyqf2_Va8pKae8OWRUhGa4ndD0sUNG3y-AM910pwLYFyqF80yUsAIXnRPjoxeMFH2gEAAFSVUK8HrwlNbHogn9fvwhEEGbynL9HWS7TsnUcCJh0P2NpAcSQyfiC_X2M1X71tUeJbno_km1bByVTSPIk2_akCVDBZiEGk-uc6qqiYjx_wgLYX0uYomqyozFcLwRh31DfgeurSBb-oJWzZo0Iu_6mfGaTbh-NinOyJJ9z5waIuyj-Y8qEwKzPDsQ-SyhL15vgOas38-mHm5yi-oNW_zPjmfOGnsthUsYTSYuewmyHwaMTjWbtuxAm1ddrxQHPV1XYpOC3ZOUP57q6qrVzNn--TzlHacrUTF9CqlN0NVMWpQF4hroAMStczy-4-1Ii8LQ1lKh2Exz321dg9BIOxxsmbpUWMJFzeCLZhvOBOt3OBzI4kbPx9YOD5uVx9CBmSZ3oP_PYPWCZDf5ms81G2DoDupU3G0gbqewNoAty0AhwtkS6nhCS4ojKsVWEeZOPw_y5VGcMVwUlJOAerr0uXaqg5Xm9Dn3PXa716B7OZiUQ2Pt2-2uTypdx7bwGPSUZiqdqvV9AxUVtZjb_SIdPyEagGyXLNtZS66RF3hlNb_0EgssagQEFRc0217B_03kbdmHNdStU0uTmouGw5W9Kb2h1CpZP1TFtZwHaCrvl8LDgwSXeXBEAbLt_fs-dPVBT0wsXTKeq8I3gJn5kCPFTEkjIOGRgKCMEhSe49k13WuPyaBlGFOqwGLkUGPg4mSl0r-n3ffgomNRSRK8bCFntCQO3y7jUCLTSIONJE6mwWRu7zNSei6wVkJuusEyp0p-jZ6KlXV4A9q7gSSlc6a8q8C-qEz9iigl2MncK75yZBFO94B-8-Vm3anaIOvwXb_2JXr4DpPwxJv_RlRyu6PShu9yD29s3Lnu1dpXsZ-T7d1B44aq5TNKawY8BWJ_ef8DDBDxVdP7El4WP5ojJurskiRg0LWzt9eraIs0oGj3asg=w1227-h860",
                            Preco= 30,
                            CategoriaId= 7
                        },
                            new Produto ()
                        {
                            NomeProduto="Moqueca de Camarão",
                            Descricao="Deliciosa moqueca de camarão",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOYkdbg50A0t0G4D5AsgqnuNij2NzIhpEI95BWVB-u7FsEISpDvEdHoisd_DzECgBv7HuLzz_eUfqi3NcXmTeg2DkdSQBQHXbSWamMahvJAwvMsisZ7y_eqe50sJuz7yr8vVNteFGdfzPeC5KzzwWn38pJbQPm13ii2dEMyz-43Vq1x2tlYWWRe-Jkgat86CPpl6lf13UxZpZhoDDsITiImVY93U9SNiR2VBFQI0NJ8yhJFqQZ7ioU5rkikhm5NsE5jIAFyslAl5j90hwt5xT-Fg6EqQtM4ewHHIBJQiUzYSrrWBrNJrydKPFkEWFcyepL_ejPr5ZwE31J0A4LKU-NEmDbZRwS5EE0NyHXC5Bt1ZjGB7gUeG88Cc9tR-SnRtgkicwNDXHrj-2uZDuHcS1H1CZ_DfxPw9ZVAj_JDtThcLehatImYmZIz99Aiaa8LTa2ZZDkCj9Aw8pp0OSyfcAwS2xtpPgl99ViVhaqD62DawS5nBoByjmu7v-80J-5hv1GbwH4vvmHItwj76IkBrxI4p74p7RvgfkdqH1ZMdUFrap5bNtGNLU4xkYLMorlY_WepmykVJxvp9eDtnzmk1tshWxaveFGENt6VOqk9N5iswOO8WMrBun1_q2Ce-Yfn-6brT1N5gh9TxzKE4H1rnHJA-xWh5vJ82WIBtp0uqO0kxs-oDQDH8F7ohYvUVJEhI_utXPDBZK3SWh5QwGoiXNLHX2vdlMM8X-WEjR9nmuCdHYp5bBoUsNUHmRi550g6W_gYzzzo-MMadICgQTfBQdNcw9PMlIGnoJHL8RYWftM12n_vAmqx-d5CiV5h3xA0hRUJekFibYblW0Qy1INzFhul2rP-YVNbFJ57G3hyRZLkqPhf8M_iMQGuQxyOavVwMDbABxHNSGZ_VA1tVjJKMPBux7G--VZyeFZG4gsqi4uKjQqjI6Uw0VHHilthxiVKvVrTW82wv0govRO12mZJb2DchZ1EEAC7QDp1CHzklDv0ThjawqYs3HOlTcwG90bFkkn8Wo0riMFJ05NgNTkRBR-Kknz6OOtebJTbGOVz2V5rYQOOkEAPyUclelk7Fx7UjuGcNG7QyHJhJots0PpWUF8Fkray7SrqYZlv1zNhHA70Bx32rOv8YoyRZ5akWv6dKCAn5w4swvwsh_GEDaqYs927k8e63s2fz-BfWIqdQ-llOl3-EQPa9SkRdpw_iulzZ9hEKf57MBcmuQHlJrvmhfPDpy-Nw2-yHdw2MHxv6RjesWjuUrfeWxPgzpbyvx5TdUfQU3UNCILLOf4Sms8qkvh4-dqY2igCuPXLPPLiHFJczCaahcJAa8JTHBS4CicAHO-YI-q3T0KAlKyOvcq81noY_XWMuUsKCWvt3LbZiH2uMX_-_UzfUt9cnBhBg6hfZ3EUfiYnY1NQ5Rr5q-u8TbFV07LMrCJGfnOqAgzk8_KD_-dfi75Ah2JcjXr4GTRXtUIxO_VF8eK1VovUgIxAOQ5tsaFDovMGdk5diHLdrGCa08xDnaA2t4jyN4xQWawx5MDW3Uw=w1227-h860",
                            Preco= 55,
                            CategoriaId= 8
                        },
                            new Produto ()
                        {
                            NomeProduto="Risoto de Camarão",
                            Descricao="Delicioso Risoto de camarão",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOZu9zeGEZ-pj2GMzg_SDweOz7CyLkfdJ0wE4guwD1q6_NyR0LVNNl-pAf1wU7WuP8hJLonBIZWXc5qAS36oj7LB0gpzqtn8MjtXim-Tj2EkSJR3BiICqW6AbH6F1NDgIXhHzb06s8Ro1yEuZ18cuB6kHAUxT1WzwBPbtkODomUFVeCCbs0Wwu8y8W_hYM_SOEyCHjtFaTEQjkJQvZO9W6LiFLHQhHxt2LqYx5K3Cb86DC4lEyvm-fHrYYY34PcZSNz8paNuHu-TcMJnEZ_9oLxgeymj5KK3Us0t2XB8VByABYWWwkXqnNOGONSo-N3I7ICGnwrK_b18FDv655V5zRAJMhsVkv3m9U340UmvhaFLMzW1FhxqTZHrSlQuF3SE6LgwS-LIuB4_If8NxrffQA02iREiCV5gpR_Gg52r1SazzC4lGGVd0LvnvAUndFkNMVCzLL3ZosfeXnYNNa69zWLLcmm8FOZaXowBfOPqDmQXnSFxl8JUnALgp2AfosgzWWAu3svd7wWSmsa4UjdjCJZXjd6r2gesws2F-w6zYcsSXWTcv2_rNtBg0WsWzNt6rkAJhxdhQjnZrFSG3SQ0xltzbGoNU3Iu887XWhwfJEjSB6TD3FlkIWGvk3E0ssexiGILrVXcfA0PJ_Hx-1hLSoXOHPjTAzIqd_y6OVYtytUSkquwYBAkzKRMMmqvdkQ4aYWjxGrIegBz0UrUYPw1X6UmAIwmZCPimaLBmouzo8dErUi9p231OLu7TExUsB7Brn5qYAjUGtGaFLBTtP7ESp9Br9dr_Pz7B0CJ9Dy36k3TojWurOS73oDbry8FaczizwAPtkqfN0fQx2ahWOShvNZwiCqGh7-1059Smkz71jjKID33jRyDqurP_0gbJoYzKk0W2g-ZgTDxyZsVGqYF2zCpAh4G5lK6L0Oea7xoVcj7TLs2nF8qUYOOZKtG_pxUNRh01XAvY6Ofxfd34odAx5bigDD-z3DTufnChgSUXkFKmFIpYlh-H2ekmuWmg_RcBga0Ot9gyL0mvC4sNmNpztmxDmXAN3e5cO-0gw6lyr6t-03naaGWrzZzV8Lyts9tDB6PmWqXYr-Kqy5I2U-46yNJus7p-vabCEh0cEQsheRGr8aisuF45bacbZ9T6eX_EtUi6Z8uTdy0yvqMk0-sL6Q2THvq6-vxl9BsBrKRwH5ufOnThdRRVjybrCSLbfwCHYzDXwB4dQDcBay3R9uMe0I93FdtyzsyBx3u6E0wSqBflfQ6X8whcrTZK9Qk8LMpxchT2GtnBupHiVJh6qo5fN1g_8Lg_NIhMB96iPrG9mJzz2u1J15pAezwMCe8-zoHBh4ykpIoeF_zurZ1Jj4YsB7qfhVRn9T-fEOVUII8Qk-NbAsmpZ8jVNaoaxbbw7yI7uTejDuNdqIR_npxIj_9b_Xqjlm4GSjNbTn5sAZ6AjaIo1lAD9dCQvh-eiCA7OL056OMj-H-mFp1bsuAeMVB9d1CDLHA2CR8gcY100MBuZc2VW8T1s4594BN98xhn42ApBdOrg=w1227-h860",
                            Preco= 55,
                            CategoriaId= 8
                        },
                            new Produto ()
                        {
                            NomeProduto="Risoto de Mexilhão",
                            Descricao="Delicioso Risoto de Mexilhão",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOawBG90tgesGy8IZpdnp9zGHez5yCH_in6Nz7pUdZ4c3w5rzIZOTRVao7SR9-SxyOaIFMqwj6QpZvrhyUksSTFv7hO66Y09HCuovA0bUqPwjPrlrTrblS2Z6Iw1WfgTTiY4z-q8xo4LPobeNGeZTbHe8hxK4xfel2NbEK5aP0LEZaB8tngzi1itybzb_x0VzDjZFsPvXv2O3SSGzHrilcTFRwxqhgM6EpP1KnvYthwmeC4EHE6yanaF-9I-4kkT8eZmKzKntimWgoHHf7Y1_egeupFqJRHI62Yjw19r4Q5tzpWva0SZRObqbCdd_kfgcEdSlZeVlSwY8S2pSH4h7yDJ40TeGn3UlZ8jE4z6OL6Y0dvGLdwSvZ7vKcO3hAqQU-rI1FgNY_ZtdVhmnB9HUtsAc7pkAP1lRdqpUYyy1ig30CmkdnYXsJphikeHo56tS10rLsOBEipFSVN3HFaVtrrczmuZZ66uW_bnazdeQmfsg2zdwehPdZ6gnYz9C1YNFO6wouYdrhynzDTB2Nnq3IW9apyG2TBcHyJz2x90rfVz6nYYvqxl4qhA6Wbmj5koTRI3Pr0sm1N87DLrXDsx3AJTvud6c3_eojLf4sipx0Pp-sE5Fq0iEnLdcslzs3dZwb_CkeSlgsIvFtFjrdgkFRPptPxSweN6uqmytGImyX9mqwKt5MNzuab0qgtb_Cm7HVMPxCNb5rWzr6wwJswFRPafdROvXQMuTw_tp3vqBiMxW_YGiKBk5X-5e_yAoBCGyrjYxO9nwe6BLziyQh0S0zUNcRJB8q7wlDPtgxkuih5rDf2ZP_BADdd9OQWi_mwL4he1AyjH3gqdjI7R1rjHIWQNj0CyEX696scGV6n3pnmp1Ir5DuTaVO2Cl2H2g1IdrpAF-XTEtkkWBTws5Rypry9oai0dEZa_OccXGlOxORkWZM5KEwjyj2w0DHgNEpcA-F67pY8FB-7B7tk4I2zT3Ie3aEUZNKPBM0WJ-bz-LrxP2bguzhXm2NdHB4vXfwH07fPq2vEbrvsrADBDyC_1JwzwvG47DHUJrZj--Kvu2NDJZtpdESUChbwTM7gP-A_9GUySD4LCThGluLsa6yLECVGJ5H7bG2pYszdzM9szIFe_-dExzbKxm7GxNUThZ5KTSZ7m_vLNlUqXNN0TCo_VM6af-JzI_CNmX1qd-nsUgwBxMSrFlIDOLpE1Fz11ULPK91McZQSWCWgqM-7GBuBSyOana838A-o_4uQGXBy1_OKRmmt6qvePdN4aIYdB8DqsdaE8Vz2WvIjnjcGhhrYY20cEP5T-ly4zNDPJxnATAT1leNWWWcORqI7vzsZJEtRZ9M82WY5yp-0vghy6FSBUjxI188xRUkn7G5CC3MOBQyUj0rc1JSxxXT1f7oRc8jhkwrHOMye3-8_plbeBR-VV3PhwVCoNfBb1iJbR8nzB3uWLKOXT7L4Gahksek3oB8H1fuWgnT4eUATrsqwYwRos2cigYZ8HDDaxpyIV3RmVDfHzMIGPbngGutqZEZFzlG9IoIfpMQ=w1227-h860",
                            Preco= 55,
                            CategoriaId= 8
                        },
                            new Produto ()
                        {
                            NomeProduto="Lula grelhada",
                            Descricao="Deliciosa Lula Grelhada",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOZSHnRT0HO_YGr5FT928hgfIC7LARuyHTHxtg_WWPX56isVBz92OYrtppShnTnDxMwGWiDSB-6Reh1iZ2vQnuGWCHBJRl6Z3i_HuMPXkGQVQVfUWCSF2wM0EeyTyY6LvqYmXWvamzHI9Gi3F1QjyZMfYtWCGswHf8xgQUrvI1DziCa-zuVX0wBHBVhT0DQM13f39hUqMluCHIfbecwV-chajMvxYDeD4ZQCLusY_BMbb2ETxQJ5Qe_JCkM8VPJjpJB_boD7Giw9HKSDqO_u6OQMwcGXAiql2uHgWoQWrimGujLhr2iyJ_VPRc1UV8A7xUA48X1nLz2ffuLLCYlGIZQ1HcnYJ7ysAOYJSElL2Pgtvtztoc7GueNqLR3LbxRwM9tShJ_7cCIRl3w_7PKTdck4Zo-8AibzBJvm1MzdK7a8hzoJEm1jznNSyzj9OA-2OspKSQfuI8gUGY_D8XaTT8cFBcp2oXuYAh31pyqZAgqdDfQ0E48X8KOpAUXyRGglfN6SmfQa0arKCr0AXutkR3m1W1SnzX_0GRQ5upe5WIlHKPaSoCUiz3Fiw9iNbnQO1qfsJXRJyX3rMtIIo_7s19mLhJmE13RBAcjQpHiH8nAByxUeP2dRkXYwCUmR5v6TKOmzDmmI9RW4ckrjxBsTtJGsBijnMi7dKWbIyyDHYjE68PXKxxgRx3qtVlmtEyuLsRpBBnQDp9Y3D7Aq5cetGnjj5v43ArSzBxLT04sWLv2Bc6o8yrbWJvdMayzWyGxUheSniH2JIYYSPpGkEZa_CV7NDYvyd8gvVJNAmVymoo1xz7GARCwdk6zDUFLk-0UeXxU49BdjuFtnYVreom8yJLLlp3ccm9fvBKmMu3VEuS1A7jRvOSk7fdo6OPNCch8Yd12tH_eSX8nzOOYI7O5NP2oG-dxofdgev8lkkfqNCryUuQpZJfm1AvvvWRahQJo6tb3DC-44Dv08ZrzFkajJ2-kNVZBIZzMwD_53Y4xahFe1l_ANuviPsZyRANlbAI8yitHz6GCZBk7_v0yon9GPDlxYondeMw6TDVXH3jVlYGZn1r8poj3f1CNTYImWdG6SjnqdeUaJdDdkanT1pTct0qx-_5qo1w61qLPRTwOOJkJivW79Z4RA6HKKg2YonUx9AH4BbQQYpGJeGPI0lre0yBp9EBRMifLqDaVlq4jVtqj5Xcs-xVgO9o0J6Ld-VSr0-edmrXpjcGj8QoHkBRlomPmJ7DPckHuwh8KZX3vNgWLkOn2S0E2Hm314m1taXA9KNSbCsf7hVjT7hYp8sF-WAOD671E_ejlMBzyIDcaeA6ItvzwfFtW335nd6uNqbf2lpjOTx5VskJh_qJae3EXxd5Kx2HkDDL128rTY93w9gjB_g7YTv9QwgXiLmLvA6pm5a7DL0RiLoOo9BrrARq1eB_194halV1UA2yJWpStImrrx1NOWv6CB6xrFrLtS4OyTzpn-KhdG3Ro4qk-ueyZpUY7vnq4eS7IlhPYpVF3r8ekApWP675eMu_r4zmn7iZSFbeCvmw=w1227-h860",
                            Preco= 62,
                            CategoriaId= 8
                        },
                            new Produto ()
                        {
                            NomeProduto="Lagosta na brasa",
                            Descricao="Deliciosa Lagosta na Brasa",
                            Imagem="https://lh3.googleusercontent.com/fife/APg5EOa5-6F0xl0AeyM5rYlGiKzPa4vtGT0D0rjvdzNM8yu1L4Aztlk4aKfxjcC1MdvJF_CJysDBVT5iVv3MqlEWDiqBl9IVrc5CVJClum8OqyBog_HlFnL3gkRz0M4PvEVXpqJKcKq-HWeX4ToF0PM4YgrGzQCjV_gybW8jX8vAPkO2UL2z77Em9okCoMjV711jCiuook66oYx4vZTJ837TFBpT4OvnOH8P74IsyqeAppl2PHuPQBFTtqw6KP9btbgqc9PrdCdc_-ySRhIrR4ZQ8KC_WzJ8P2gcx72G9BM6mSeO2KtOCHUEcwjKHZJmV6S8ThLojL2aLM36zCj3x1FgN5lE5lV1j9pfOh4yKPNMQiGLAfbFAnwjYd6tEkl0gPD4nMzbgqFbFtt55ZPszICs2cP0Wa2TokeFbGqsBz4hkZc8RYUeOpiqw9Uh04FLGGbZlMwhWJvFwerUBGh8IfTznfrstGD2gbxD9pq8NWG9IBdJon2gInrpEtWkOebFGBQ127qZXgd9UicRj8LTxNaTi-vwR9x8HBHN0QvgZvmmNwS-dhxoL3wPQlICWHthz4ZhBYjMX3re__ga1iMN9c5yvCyzveQeKuFaxbkTWJfuIU8oTfzGmhoJPpBwhbWXAI3VpjOwAx7oF5huqwzBVl_bktTsIQJkOTvHuc2C077rj3vwsffSRnLVAoNuvqGdvuKa4hQghztA43TWm_jwRPxFPXxBEHO_B5chH0PSWkszng4an4koarJBs9GBqONJG-oNlYpOE1-8A9bYyznlsdmRZrpbO4UsICJN6PdZLL3kepAmpcufgfTLVEMMIherezw0nFDrcvwOZI7soVLFEnS4N7dkZ0FIwoxEP03W1eK7CdVQBTlcglbUSuUA6JCBO1HarJrxYoYAHfnKhP0Ku6H8hJ1VyM5vSrZwZm8cqF2rxC2l6fuxOZINj9Y0zlqFMs_IVbwllq5n-i4a4ixA-GqR5c1C3RB6yR2_A0H17zJAoNTypvLMxIEgHpuxkffTCdCG2QlYnumc06p590z3wej25PpTihYx7NBphrtHqQhaM6kLjuEvViB8_TzY4OP38qVWW2YXrxiJBcXwTjKtd5qnroPPMekZKpjNYndxpR5xsXgu2cvgYCrSJ9_SgJvdSdXkYKNJQ4CL_p_5EqKxLp7AjQTyGRw0UUOgGFlI042j9Y4MZMgOC2m4GlLli5Pu2_I71TXePyfb9OotvsAFOQ1Wy56vNaNg12LlRhML7OYbQjL5k0iVHkXmqJqeo-idVsL0IzKT-hHFlz0udAGmbSrcgQfU-Hgfmb-TqGS7MUjKPiIXUw7mxpplT1fdGsKuHhTuUaJaliTmYuoRyBaebAssSgWX00trNf6oBnhrIpd4Vj3F7KbGOdTHASb53uaO0DJaaoKoYeTGN0r0vDFPD_a9LLGQabgeyemp5GN3ZH3L2FhGygyZ9NOZAQkcNbwloRfQkcnTAwiijRVcoTzmnuNkNtLsxUfQTirUIx479WDtGetX7xGt9DRBIomaKANJnR2tmzeQkQ=w1227-h860",
                            Preco= 100,
                            CategoriaId= 8
                        },
                           
                    });
                    context.SaveChanges();
                }
                //Reservas
                if (!context.Reservas.Any())
                {
                    context.Reservas.AddRange(new List<Reserva> ()
                    {
                        new Reserva()
                        {
                        DataHoraCriacao = DateTime.Now.AddDays(-10),
                        DataHoraReserva = DateTime.Now.AddDays(-10),
                        Descricao = "",
                        Situacao = true,
                        ClienteId = 1,
                        MesaId = 1
                        },
                        new Reserva()
                        {
                        DataHoraCriacao = DateTime.Now.AddDays(-10),
                        DataHoraReserva = DateTime.Now.AddDays(-10),
                        Descricao = "",
                        Situacao = true,
                        ClienteId = 1,
                        MesaId = 1
                        },
                        new Reserva()
                        {
                        DataHoraCriacao = DateTime.Now.AddDays(-10),
                        DataHoraReserva = DateTime.Now.AddDays(-10),
                        Descricao = "",
                        Situacao = true,
                        ClienteId = 1,
                        MesaId = 1
                        },
                        new Reserva()
                        {
                        DataHoraCriacao = DateTime.Now.AddDays(-10),
                        DataHoraReserva = DateTime.Now.AddDays(-10),
                        Descricao = "",
                        Situacao = true,
                        ClienteId = 1,
                        MesaId = 1
                        },
                    });
                    context.SaveChanges();
                }
                //Agenda
                if (!context.Agendas.Any())
                {
                    context.Agendas.AddRange(new List<Agenda>()
                    {
                        new Agenda()
                        {
                            Data = DateTime.Now.AddDays(-10),
                            Horario = "13:00",
                            MesaId = 1
                        },
                        new Agenda()
                        {
                            Data = DateTime.Now.AddDays(-10),
                            Horario = "18:00",
                            MesaId = 1
                        },
                        new Agenda()
                        {
                            Data = DateTime.Now.AddDays(-10),
                            Horario = "20:00",
                            MesaId = 1
                        },
                        new Agenda()
                        {
                            Data = DateTime.Now.AddDays(-10),
                            Horario = "15:00",
                            MesaId = 1
                        },

                        new Agenda()
                        {
                            Data = DateTime.Now.AddDays(-10),
                            Horario = "12:00",
                            MesaId = 2                            
                        },

                        new Agenda()
                        {
                            Data = DateTime.Now.AddDays(-10),
                            Horario = "08:00",
                            MesaId = 3
                        },
                    });
                    context.SaveChanges();                
                }
                                
                                //Avaliacoes
                               /* if (!context.Restaurantes.Any())
                                {
                                    context.Clientes.AddRange(new List<Cliente>()
                                    {

                                    });

                                }*/
            }
        }
    }
}

